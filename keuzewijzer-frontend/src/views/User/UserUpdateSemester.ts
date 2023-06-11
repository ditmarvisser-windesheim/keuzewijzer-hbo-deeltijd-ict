import { type View } from '../View';
import Api from '../../api/api';
import Swal from 'sweetalert2';
import { type Semester } from 'models/Semester';
import { type User } from 'models/User';

export class UserUpdateSemester implements View {
  private readonly Id = 1; // TODO: get the id form the url
  private user: User | null = null;

  public template = `
    <div class="container mt-2 mb-2">
      <div class="row">
        <div class="col-3 d-flex justify-content-start">
          <a href="/user" data-link class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">Terug</a>
        </div>
        <div class="col-9">
          <h1>Gebruiker semesters toewijzen</h1>
        </div>
      </div>
      
      <form id="user-form">
        <input type="hidden" id="id">
        <div class="form-group">
          <label for="year">Semester:</label>
          <select class="form-select" id="semesters" multiple>
          </select>
          <div id="semesterError" class="invalid-feedback"></div>
        </div>
        <button type="submit" class="btn btn-primary">Aanmaken</button>
      </form>
    </div>
  `;

  public data = {};

  public async setup (): Promise<void> {
    this.user = await Api.get('/api/User/' + this.Id.toString()) as User;
    this.updateSemesters();

    const userForm = $('#user-form');
    userForm.on('submit', this.handleUserSemesterUpdate.bind(this));
  }

  private async updateSemesters (): Promise<void> {
    const SemesterSelect = $('#semesters');
    const Semesters = await Api.get('/api/semesterItem') as Semester[];

    // TODO: check which of the semester items are already selected

    Semesters.forEach((semesterItem: Semester) => {
      if (semesterItem.id === this.Id) return;
      SemesterSelect.append(`<option value="${semesterItem.id}">${semesterItem.name}</option>`);
    });
  }

  private async handleUserSemesterUpdate (event: Event): Promise<void> {
    event.preventDefault();
    const semestersInput = $('#semesters');
    const semesterError = $('#semesterError');

    const semesters = semestersInput.val() as string[];
    const semesterIds = semesters.map((semester) => parseInt(semester));

    if (semesterIds.length === 0) {
      semesterError.text('Selecteer minstens 1 semester');
      semesterError.addClass('d-block');
      return;
    }

    try {
      // Make the POST request to the server
      const response = await Api.put('/api/User/UpdateSemesters/' + this.Id, semesterIds);
      if (response.name === undefined) {
        Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
        return;
      }

      // Show a success message
      Swal.fire('Semester ' + response.name + ' Aangepast!', '', 'success');
      console.log(response);

      // Go back to the semester overview wait for 3 seconds
      setTimeout(function () {
        window.location.href = '/user';
      }, 2000);
    } catch (error) {
      Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
    }
  }
}
