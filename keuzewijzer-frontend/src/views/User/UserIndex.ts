import { type View } from '../View';

import Swal from 'sweetalert2';
import { ApiService } from 'services/ApiService';
import { IUser } from 'interfaces/iUser';

export class UserIndexView implements View {
  public apiService!: ApiService;
  
  public template = `
    <div class="container mt-2">
      <div class="row">
        <div class="col-9">
          <h1>Gebruikers</h1>
        </div>
        <div class="col-3 d-flex justify-content-end">
          <a href="/user" data-link class="btn btn-primary btn-lg active" role="button" aria-pressed="true">Gebruiker aanmaken</a>
        </div>
      </div>  

      <table class="table">
        <thead>
          <tr>
            <th scope="col">Name</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="semesterItems">
          <div id="loading" class="d-flex justify-content-center">
            <div class="spinner-border" role="status">
              <span class="sr-only"></span>
            </div>
          </div>        
        </tbody>
      </table>
    </div>
  `;

  public data = {};

  public async setup (): Promise<void> {
    try {
      const users = await this.apiService.get<IUser[]>('/api/User');
      
      $('#loading').remove();

      if (Array.isArray(users)) {
        users.forEach((user) => {
          const tableBody = document.getElementById('semesterItems');
          if (tableBody != null) {
            const row = $('<tr>').append(
              $('<td>').text(user.name),
              $('<td>').append(
                $('<a>').attr('href', '/userUpdateSemester?id=' + user.id)
                  .addClass('btn btn-primary btn-sm active')
                  .attr('role', 'button')
                  .attr('aria-pressed', 'true')
                  .text('Semester toewijzen')
              )

            );
            row.appendTo(tableBody);
          }
        });
      } else {
        console.error('Users is not an array');
      }
    } catch (error) {
      console.error('Error fetching users:', error);
    }
  }
}
