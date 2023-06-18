import Swal from 'sweetalert2';

import { type View } from '../View';
import { type ISemester } from 'interfaces/iSemester';
import { type IUser } from 'interfaces/iUser';
import { type ApiService } from 'services/ApiService';

export class UserUpdateSemesterView implements View {
  private readonly user: IUser | null = null;
  public apiService!: ApiService;

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
  public params: Record<string, string> = {};

  public async setup (): Promise<void> {
    const response = await this.apiService.get<IUser>(`/api/User/${this.params?.id}`);

    if ('status' in response && response.status === 404) {
      Swal.fire({
        title: 'Fout!',
        text: 'Gebruiker niet gevonden!',
        icon: 'error',
        confirmButtonText: 'Oké'
      });

      setTimeout(() => {
        window.location.href = '/user';
      }, 2000);

      return;
    }
    await this.updateSemesters();

    const user = response;

    await this.setForm(user);

    const userForm = $('#user-form');
    userForm.on('submit', this.handleUserSemesterUpdate.bind(this));
  }

  private async setForm (user: IUser): Promise<void> {
    const semestersInput = $('#semesters');
    const semesterError = $('#semesterError');

    if (user.semesterItems != null) {
      const semesters = user.semesterItems.map((semester) => {
        if (semester.id != null) {
          return semester.id.toString();
        }

        return '';
      });
      semestersInput.val(semesters);
    };
  }

  private async updateSemesters (): Promise<void> {
    const SemesterSelect = $('#semesters');
    const Semesters = await this.apiService.get<ISemester[]>('/api/semesterItem');

    Semesters.forEach((semesterItem: ISemester) => {
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
      const response = await this.apiService.put<any>(`/api/User/UpdateSemesters/${this.params?.id}`, semesterIds);

      if (response.name === undefined) {
        Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
        return;
      }

      // Show a success message
      Swal.fire(`Semester ${response.name} Aangepast!`, '', 'success');

      // Go back to the semester overview wait for 3 seconds
      setTimeout(function () {
        window.location.href = '/user';
      }, 2000);
    } catch (error) {
      Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
    }
  }
}
