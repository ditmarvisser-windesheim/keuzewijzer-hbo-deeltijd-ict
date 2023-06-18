import { type IUserData } from 'interfaces/iUserData';
import type AuthService from 'services/AuthService';

class SidebarPartial {
  private readonly userData: IUserData | null;
  private readonly authService: AuthService | undefined;

  constructor (authService: AuthService, userData: IUserData | null) {
    this.authService = authService;
    this.userData = userData;
  }

  public template = `
        <div class="d-flex flex-column align-items-center align-items-sm-start px-3 pt-2 text-white min-vh-100 sticky-top">
            <a href="/" class="d-flex align-items-center pb-3 mb-md-0 me-md-auto text-white text-decoration-none">
                <span class="fs-5 d-none d-sm-inline">HBO-ICT</span>
            </a>
            <ul class="nav nav-pills flex-column mb-sm-auto mb-0 align-items-center align-items-sm-start" id="menu">
                <li class="nav-item">
                    <a href="#" class="nav-link text-white">
                        <span class="ms-1 d-none d-sm-inline">Studieroute</span>
                    </a>
                </li>
                {{#if (eq isAuthenticated true)}}
                    {{#if (contains_role userData.roles "Moduleverantwoordelijke,Administrator")}}
                    <li>
                        <a href="/semester" class="nav-link text-white">
                            <span class="ms-1 d-none d-sm-inline">Module</span>
                        </a>
                    </li>
                    <li>
                        <a href="/cohort" class="nav-link text-white">
                            <span class="ms-1 d-none d-sm-inline">Cohort</span>
                        </a>
                    </li>
                    {{/if}}
                    {{#if (contains_role userData.roles "Administrator")}}
                    <li>
                        <a href="/user" class="nav-link text-white">
                            <span class="ms-1 d-none d-sm-inline">Gebruikers</span>
                        </a>
                    </li>
                    {{/if}}
                    {{#if (contains_role userData.roles "Docent")}}
                    <li>
                        <a href="/students" class="nav-link text-white">
                            <span class="ms-1 d-none d-sm-inline">Mijn Studenten</span>
                        </a>
                    </li>
                    {{/if}}
                {{/if}}
            </ul>
            <hr>
            <div class="nav nav-pills mb-0 px-3 align-items-center row fixed-bottom">
            {{#if (eq isAuthenticated true)}}
                <div class="col-sm-12  text-white">Ingelogd als: <b>{{userData.email}}</b></div>
                <a href="/logout" id="logout" class="align-middle col-sm-12">
                    Uitloggen
                </a>
            {{else}}
                <a href="/login" class="col-sm-12" data-link>
                    Inloggen
                </a>
            {{/if}}
            </div>
        </div>
      `;

  public setup (): void {
    $(async () => {
      const menu = document.getElementById('menu');
      if (menu != null) {
        menu.addEventListener('click', (event) => {
          const target = event.target as HTMLElement;
          const active = document.getElementsByClassName('active');

          if (active.length > 0) {
            active[0].classList.remove('active');
          }

          target.classList.add('active');
        });
      }

      const logout = document.getElementById('logout');
      logout?.addEventListener('click', (event) => {
        event.preventDefault();
        this.logout();
      });
    });
  }

  private async logout (): Promise<void> {
    try {
      await this.authService?.logout().then(() => {
        window.location.href = '/';
      });
    } catch (error) {
      console.error('Logout failed:', error);
    }
  }
}

export default SidebarPartial;
