import { type View } from '../View';
import Swal from 'sweetalert2';
import { ApiService } from 'services/ApiService';
import { IUser } from 'interfaces/iUser';
import { IRole } from 'interfaces/iRole';
import AuthService from 'services/AuthService';
import { IUserData } from 'interfaces/iUserData';

export class UserUpdateRoleView implements View {
  public apiService!: ApiService;

  public authService!: AuthService;

  public params: Record<string, string> = {};

  private user = {} as IUser;

  public template = `
  <div class="container mt-2 mb-2">
    <div class="row">
      <div class="col-3 d-flex justify-content-start">
        <a href="/user" data-link class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">Terug</a>
      </div>
      <div class="col-9">
        <h1 id="name"></h1>
      </div>
    </div>
    
    <form id="user-form">
      <input type="hidden" id="id">
      <div class="form-group">
        <label for="year">Rollen:</label>
        <div class="checkBoxContainer", id="roles"></div>
        <div id="studentError" class="invalid-feedback"></div>
        <div id="roleError" class="invalid-feedback"></div>
      </div>
      <button type="submit" class="btn btn-primary">Aanpassen</button>
    </form>
  </div>
`;

  public data = {};

  public async setup (): Promise<void> {
    this.setForm();

    const userForm = $('#user-form');
    userForm.on('submit', this.handleUserUpdate.bind(this));
  }

  private async setForm (): Promise<void> {
    // TODO: get the id from the url
    const id = this.params?.id;

    //Search for the user item with the id
    var updateUser = await this.apiService.get<IUser>(`/api/User/${id}`);
    this.user = updateUser;
    
    // Get all Roles and check the current roles of the user
    var rolesArray = await this.apiService.get<string[]>(`/api/User/${this.user.id}/roles`);

    const roles = await this.apiService.get<IRole[]>(`/api/Role`);

    $.each(roles, function (index, role) {
      let checkbox = `<input type='checkbox' class="form-check-input" id="role-${role.id}" value="${role.name}" name="role-${role.id}"`;

      if (Array.isArray(rolesArray)) {
        if (rolesArray.includes(role.name)) {
          checkbox += ' checked';
        }
      }

      checkbox += `><label for="role-${role.id}">${role.name}</label><br>`;
      $('.checkBoxContainer').append($(checkbox));
    });

    // set the values of the form
    $('#name').html(updateUser.name);
    $('#id').val(updateUser.id);
  }

  public validateInputStudents(roles: string[], id: string){
    // Check if student has any other roles
    if (roles.includes("Student") && (roles.length > 1)) {
      return false;
    }
    return true
  }

  public validateInputAdmin(roles: string[], id: string, userdata: IUserData | null){
    // Check if admin is removing himself from the admin role
    if(id == userdata?.userId && !roles.includes("Administrator")){
      return false;
    }
    return true
  }

  private async handleUserUpdate(event: Event): Promise<void> {
    event.preventDefault();

    const rolesInput = $('#roles');

    const roles: (string)[] = [];
    $('#roles input:checked').each(function () {
      roles.push($(this).attr('value') as string);
    });


    const id = $('#id').val() as string;

    // Validate inputs
    if (!this.validateInputStudents(roles, id)){
      const studentError = $('#studentError');
      studentError.text('Een student kan geen andere rollen hebben.');
      studentError.addClass('d-block');
      return
    }

    const userdata = this.authService?.getUserData();

    if (!this.validateInputAdmin(roles, id, userdata)){
      const roleError = $('#studentError');
      roleError.text('Een admin kan de admin role niet bij zichzelf verwijderen.');
      roleError.addClass('d-block');
      return
    }

    try {
      // Make the PUT request to the server
      const response = await this.apiService.put<IUser>(`/api/User/${id}/roles`, roles);
      if (response.name === undefined) {
        Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
        return;
      }

      // Show a success message
      Swal.fire('User ' + response.name + ' Aangepast!', '', 'success');

      // Go back to the user overview wait for 3 seconds
      setTimeout(function () {
        window.location.href = '/user';
      }, 2000);
    } catch (error) {
      Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
    }
  }
}
