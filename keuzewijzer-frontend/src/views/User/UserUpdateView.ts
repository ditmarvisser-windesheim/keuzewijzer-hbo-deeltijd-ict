import { View } from '../View';
import Swal from 'sweetalert2';
import Api from '../../js/api/api';
import { User } from '../../../Models/User';
import { Role } from '../../../Models/Role';

export class UserUpdateView implements View {

  private Id = 5; //TODO: get the id form the url

  public template = `
  <div class="container mt-2 mb-2">
    <div class="row">
      <div class="col-3 d-flex justify-content-start">
        <a href="/user" data-link class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">Terug</a>
      </div>
      <div class="col-9">
        <h1>User aanpassen</h1>
      </div>
    </div>
    
    <form id="user-form">
      <input type="hidden" id="id">
      <div class="form-group">
        <label for="name">Naam:</label>
        <input type="text" class="form-control" id="name">
        <div id="nameError" class="invalid-feedback"></div>
      </div>
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
    const id = this.Id;

    //Search for the user item with the id
    var response = await Api.get(`/api/user/${id}`);
    var updateUser = response as User;
    var rolesArray = updateUser.roles.map(r => r.id)

    var roles = await Api.get(`/api/role`) as Role[];

    $.each(roles,function(index, role){
      var checkbox=`<input type='checkbox' class="form-check-input" id="role-${role.id}" value="${role.id}" name="role-${role.id}"`;
      
      if (rolesArray.includes(role.id)) {
        checkbox += " checked";
      }
      
      checkbox += `><label for="role-${role.id}">${role.name}</label><br>`;
      $(".checkBoxContainer").append($(checkbox));
    })

    //set the values of the form
    $('#name').val(updateUser.name);
    $('#id').val(updateUser.id);
  }


  private async handleUserUpdate(event: Event): Promise<void> {
    event.preventDefault();

    const nameInput = $('#name');
    console.log(nameInput);

    const rolesInput = $('#roles')
    console.log(rolesInput);
    
    const name = nameInput.val() as string;
    console.log(name);

    const roles: (string | undefined)[] = [];
    $('#roles input:checked').each(function() {
      roles.push($(this).attr('value'));
    });
    

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

    const userItem = {
      "id": "string",
      "userName": "string",
      "normalizedUserName": "string",
      "email": "string",
      "normalizedEmail": "string",
      "emailConfirmed": true,
      "passwordHash": "string",
      "securityStamp": "string",
      "concurrencyStamp": "string",
      "phoneNumber": "string",
      "phoneNumberConfirmed": true,
      "twoFactorEnabled": true,
      "lockoutEnd": "2023-05-31T18:56:28.108Z",
      "lockoutEnabled": true,
      "accessFailedCount": 0,
      "name": "string",
      "firstName": "string",
      "lastName": "string",
      "roles": [
        {
          "id": 0,
          "name": "string",
          "users": [
            "string"
          ]
        }
      ],
      "timedOut": "2023-05-31T18:56:28.108Z",
      "cohortId": 0
    }

    try {
      // Make the POST request to the server
      const response = await Api.put('/api/user/' + id, userItem);
      if (response.name === undefined) {
        Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
        return;
      }

      // Show a success message
      Swal.fire('Semester ' + response.name + ' Aangepast!', '', 'success');
      console.log(response);

      // Go back to the semester overview wait for 3 seconds
      setTimeout(function () {
        window.location.href = '/semester';
      }, 2000);

    } catch (error) {
      Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
    }
  }

}