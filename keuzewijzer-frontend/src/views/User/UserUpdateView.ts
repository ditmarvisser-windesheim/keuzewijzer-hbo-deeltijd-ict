import { View } from '../View';
import Swal from 'sweetalert2';
// import { Semester } from 'Models/Semester';
import Api from '../../js/api/api';
import { User } from '../../../Models/User';
import { Role } from '../../../Models/Role';
// import { Cohort } from 'Models/Cohort';

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
    
    <form id="semester-form">
      <input type="hidden" id="id">
      <div class="form-group">
        <label for="name">Naam:</label>
        <input type="text" class="form-control" id="name">
        <div id="nameError" class="invalid-feedback"></div>
      </div>
      <div class="form-group">
        <label for="year">Rollen:</label>
        <div class="checkBoxContainer"></div>
      </div>
      <button type="submit" class="btn btn-primary">Aanpassen</button>
    </form>
  </div>
`;

  public data = {};

  public async setup(): Promise<void> {
    this.setForm();

    const semesterForm = $('#semester-form');
    semesterForm.on('submit', this.handleSemesterUpdate.bind(this));
  }

  private async setForm(): Promise<void> {
    //TODO: get the id from the url
    const id = this.Id;

    //Search for the user item with the id
    var response = await Api.get(`/api/user/${id}`);
    var updateUser = response as User;
    console.log(updateUser);
    

    var roles = await Api.get(`/api/role`) as Role[];

    $.each(roles,function(index, role){
        console.log(role.name)
        var checkbox=`<input type='checkbox' class="form-check-input" id="role-${role.id}" value="${role.id}" name="role-${role.id}"><label for="role-${role.id}">${role.name}</label><br>`
        $(".checkBoxContainer").append($(checkbox));
    })

    //set the values of the form
    $('#name').val(updateUser.name);
    

    
  }


  private async handleSemesterUpdate(event: Event): Promise<void> {
    event.preventDefault();

    const nameInput = $('#name');
    const descriptionInput = $('#description');
    const semesterInput = $('#semester');
    const yearSelect = $('#year');
    const name = nameInput.val() as string;
    const description = descriptionInput.val() as string;
    const semester = parseInt(semesterInput.val() as string);
    const year = yearSelect.val() as string[];
    const id = parseInt($('#id').val() as string);

    const cohort = $('#cohorts').val() as string[];
    const cohortInt = cohort.map(Number);
    const requiredSemesterItem = $('#requiredSemesterItem').val() as string[];
    const requiredSemesterItemInt = requiredSemesterItem.map(Number);

    const nameError = $('#nameError');
    const descriptionError = $('#descriptionError');
    const semesterError = $('#semesterError');
    const yearError = $('#yearError');

    if (name.length < 4 || name.length > 100) {
      nameError.text('Semester item naam moet tussen de 4 en 100 karakters zijn.');
      nameError.addClass('d-block');
      return;
    }

    if (!description) {
      descriptionError.text('Vul alle verplichte velden in.');
      descriptionError.addClass('d-block');
      return;
    }

    if (!semester) {
      semesterError.text('Vul alle verplichte velden in.');
      semesterError.addClass('d-block');
      return;
    }

    if (semester < 1 || semester > 2) {
      semesterError.text('Semester moet een waarde tussen 1 en 2 hebben.');
      semesterError.addClass('d-block');
      return;
    }

    if (year.length === 0) {
      yearError.text('Selecteer minimaal 1 jaar.');
      yearError.addClass('d-block');
      return;
    }

    //check if the year in the year array are unique and between 1 and 4
    const uniqueYear = [...new Set(year)];
    if (uniqueYear.length !== year.length) {
      yearError.text('Selecteer unieke jaren.');
      yearError.addClass('d-block');
      return;
    }

    for (let i = 0; i < year.length; i++) {
      if (parseInt(year[i]) < 1 || parseInt(year[i]) > 4) {
        yearError.text('Selecteer jaren tussen 1 en 4.');
        yearError.addClass('d-block');
        return;
      }
    }

    const semesterItem = {
      id: id,
      name: name,
      description: description,
      semester: semester,
      Year: year,
      Cohorts: [],
      CohortsId: cohortInt,
      RequiredSemesterItemId: requiredSemesterItemInt,
      RequiredSemesterItem: [],
      DependentSemesterItem: []
    };

    try {
      // Make the POST request to the server
      const response = await Api.put('/api/semesterItem/' + id, semesterItem);
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