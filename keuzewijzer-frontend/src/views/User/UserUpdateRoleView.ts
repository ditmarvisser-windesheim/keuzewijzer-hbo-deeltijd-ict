import { View } from '../View';
import Swal from 'sweetalert2';
import Api from '../../js/api/api';
import { User } from '../../../Models/User';
import { Role } from '../../../Models/Role';

export class UserUpdateRoleView implements View {

  // private Id = 5; //TODO: get the id form the url
  public params: Record<string, string> = {};
  
  private user: User = new User;

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
      </div>
      <button type="submit" class="btn btn-primary">Aanpassen</button>
    </form>
  </div>
`;

  public data = {};

  public async setup(): Promise<void> {
    
    this.setForm();
    
    const userForm = $('#user-form');
    userForm.on('submit', this.handleUserUpdate.bind(this));
  }
  
  private async setForm(): Promise<void> {
    //TODO: get the id from the url
    const id = this.params?.id;
    console.log("p");
    console.log(this.params);
    console.log("p");

    //Search for the user item with the id
    var response = await Api.get(`/api/user/${id}`);
    console.log(this.user);
    var updateUser = response as User;
    this.user = updateUser;
    console.log(this.user);

    console.log(updateUser);
    


    // var rolesArray = updateUser.roles.map(r => r.id)
    var rolesArray = await Api.get(`/api/User/${this.user.id}/roles`)

    var roles = await Api.get(`/api/role`) as Role[];

    $.each(roles,function(index, role){
      var checkbox=`<input type='checkbox' class="form-check-input" id="role-${role.id}" value="${role.name}" name="role-${role.id}"`;
      
      if (Array.isArray(rolesArray)) {
        if (rolesArray.includes(role.name)) {
          checkbox += " checked";
        }
      }
      
      checkbox += `><label for="role-${role.id}">${role.name}</label><br>`;
      $(".checkBoxContainer").append($(checkbox));
    })

    //set the values of the form
    $('#name').html(updateUser.name);
    $('#id').val(updateUser.id);
  }


  private async handleUserUpdate(event: Event): Promise<void> {
    event.preventDefault();

    const rolesInput = $('#roles')
    console.log(rolesInput);
    
    const roles: (string | undefined)[] = [];
    $('#roles input:checked').each(function() {
      roles.push($(this).attr('value'));
    });

    console.log(roles);
    
    

    const id = parseInt($('#id').val() as string);

    // const cohort = $('#cohorts').val() as string[];
    // const cohortInt = cohort.map(Number);
    // const requiredSemesterItem = $('#requiredSemesterItem').val() as string[];
    // const requiredSemesterItemInt = requiredSemesterItem.map(Number);

    // const nameError = $('#nameError');
    // const descriptionError = $('#descriptionError');
    // const semesterError = $('#semesterError');
    // const yearError = $('#yearError');

    // if (name.length < 4 || name.length > 100) {
    //   nameError.text('Semester item naam moet tussen de 4 en 100 karakters zijn.');
    //   nameError.addClass('d-block');
    //   return;
    // }

    try {
      // Make the PUT request to the server
      const response = await Api.put('/api/user/' + id + '/roles', roles);
      console.log(response);
      if (response.name === undefined) {
        Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
        return;
      }

      // Show a success message
      Swal.fire('User ' + response.name + ' Aangepast!', '', 'success');
      console.log(response);

      // Go back to the user overview wait for 3 seconds
      setTimeout(function () {
        window.location.href = '/user';
      }, 2000);

    } catch (error) {
      Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
    }
  }

}