
import Swal from 'sweetalert2';

import { type View } from '../View';
import { getAllUsers } from '../../api/user';
import { IUser } from 'interfaces/iUser';
import { createCohort } from '../../api/cohort';

export class CohortCreateView implements View {
  public template = `
  <div class="container mt-2 mb-2">
    <div class="row">
      <div class="col-3 d-flex justify-content-start">
        <a href="/cohort" data-link class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">Terug</a>
      </div>
      <div class="col-9">
        <h1>Cohort toevoegen</h1>
      </div>
    </div>
    
    <form id="cohort-form">
      <div class="form-group">
        <label for="name">Naam:</label>
        <input type="text" class="form-control" id="name">
        <div id="nameError" class="invalid-feedback"></div>
      </div>
      <div class="form-group">
        <label for="year">Jaar:</label>
        <input type="number" class="form-control" id="year" min="1" >
        <div id="yearError" class="invalid-feedback"></div>
      </div>
      <div class="form-group">
      <label for="year">Beheerder:</label>
      <select class="form-select" id="user">
      </select>
      <div id="userError" class="invalid-feedback"></div>
      </div> 
      <button type="submit" id="submit" class="btn btn-primary">Aanmaken</button>
    </form>
  </div>
`;

  public data = {};

  public setup (): void {
    this.updateUsers().catch((error) => {
      console.error(error);
    });

    const cohortForm = $('#cohort-form');
    cohortForm.on('submit', this.handleCohortCreate.bind(this));
  }

  private async updateUsers (): Promise<void> {
    const userSelect = $('#user');

    await getAllUsers()
      .then((response) => {
        response.forEach((user: IUser) => {
          userSelect.append(`<option value="${user.id}">${user.name}</option>`);
        });
      });
  }

  private async handleCohortCreate (event: Event): Promise<void> {
    event.preventDefault();
    const nameInput = $('#name');
    const yearSelect = $('#year');
    const userSelect = $('#user');

    const name = nameInput.val() as string;
    const year = parseInt(yearSelect.val() as string);
    const userId = parseInt(userSelect.val() as string);

    const nameError = $('#nameError');
    const yearError = $('#yearError');
    const userError = $('#userError');

    if (name.length < 4 || name.length > 254) {
      nameError.text('Semester item naam moet tussen de 4 en 254 karakters zijn.');
      nameError.addClass('d-block');
      return;
    }

    if (userId === null) {
      userError.text('Beheerder is verplicht.');
      userError.addClass('d-block');
      return;
    }

    if (isNaN(year) || year < 1800 || year > 3000) {
      yearError.text('Ongeldig jaar.');
      yearError.addClass('d-block');
      return;
    }

    $('#submit').attr('disabled', 'disabled');

    const cohort = {
      name,
      year: year,
      semesterItems: [],
      UserId: userId,
      User: null
    };

    try {
      // Make the POST request to the server
      const response = await createCohort(cohort)
        .then((response) => {
          Swal.fire('Cohort ' + response.name + ' Aangemaakt!', '', 'success');
        })
        .catch(() => {
          Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
        });

      // Go back to the semester overview wait for 3 seconds
      setTimeout(() => {
        $('#submit').attr('disabled', 'disabled');
        window.location.href = '/cohort';
      }, 2000);
    } catch (error) {
      $('#submit').removeAttr('disabled');
      Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
    }
  }
}
