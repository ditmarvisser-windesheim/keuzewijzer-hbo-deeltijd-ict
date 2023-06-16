import Swal from 'sweetalert2';

import { type View } from '../View';
import { ISemester } from 'interfaces/iSemester';
import { ICohort } from 'interfaces/iCohort';
import { ApiService } from 'services/ApiService';

export class SemesterCreateView implements View {
  public apiService!: ApiService;

  public template = `
  <div class="container mt-2 mb-2">
    <div class="row">
      <div class="col-3 d-flex justify-content-start">
        <a href="/semester" data-link class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">Terug</a>
      </div>
      <div class="col-9">
        <h1>Module toevoegen</h1>
      </div>
    </div>
    
    <form id="semester-form">
      <div class="form-group">
        <label for="name">Naam:</label>
        <input type="text" class="form-control" id="name">
        <div id="nameError" class="invalid-feedback"></div>
      </div>
      <div class="form-group">
        <label for="description">Beschrijving:</label>
        <textarea class="form-control" id="description" rows="3"></textarea>
        <div id="descriptionError" class="invalid-feedback"></div>
      </div>
      <div class="form-group">
        <label for="semester">Semester:</label>
        <input type="number" class="form-control" id="semester" min="1" max="2">
        <div id="semesterError" class="invalid-feedback"></div>
      </div>
      <div class="form-group">
        <label for="year">Jaar:</label>
        <select class="form-select" id="year" multiple>
          <option value="1">1</option>
          <option value="2">2</option>
          <option value="3">3</option>
          <option value="4">4</option>
        </select>
        <div id="yearError" class="invalid-feedback"></div>
      </div>
      <div class="form-group">
      <label for="year">Cohorts:</label>
        <select class="form-select" id="cohorts" multiple>
        </select>
      </div>
      <div class="form-group">
      <label for="year">Benodigde semester:</label>
      <select class="form-select" id="requiredSemesterItem" multiple>
      </select>
    </div>
      <button type="submit" id="submit" class="btn btn-primary">Aanmaken</button>
    </form>
  </div>
`;

  public data = {};

  public setup(): void {
    this.updateRequiredSemesterItem();
    this.updateCohorts();

    const semesterForm = $('#semester-form');
    semesterForm.on('submit', this.handleSemesterCreate.bind(this));
  }

  private async updateCohorts(): Promise<void> {
    const cohortSelect = $('#cohorts');
    const cohorts = await this.apiService.get<ICohort[]>('/api/Cohort');

    cohorts.forEach((cohort: ICohort) => {
      cohortSelect.append(`<option value="${cohort.id}">${cohort.name}</option>`);
    });
  }

  private async updateRequiredSemesterItem(): Promise<void> {
    const requiredSemesterItemSelect = $('#requiredSemesterItem');
    const requiredSemesterItem = await this.apiService.get<ISemester[]>('/api/semesterItem');

    requiredSemesterItem.forEach((semesterItem: ISemester) => {
      requiredSemesterItemSelect.append(`<option value="${semesterItem.id}">${semesterItem.name}</option>`);
    });
  }

  private async handleSemesterCreate(event: Event): Promise<void> {
    event.preventDefault();
    const nameInput = $('#name');
    const descriptionInput = $('#description');
    const semesterInput = $('#semester');
    const yearSelect = $('#year');
    const name = nameInput.val() as string;
    const description = descriptionInput.val() as string;
    const semester = parseInt(semesterInput.val() as string);
    const year = yearSelect.val() as string[];
    const requiredSemesterItem = $('#requiredSemesterItem').val() as string[];
    const cohort = $('#cohorts').val() as string[];
    const cohortInt = cohort.map(Number);
    const requiredSemesterItemInt = requiredSemesterItem.map(Number);
    const nameError = $('#nameError');
    const descriptionError = $('#descriptionError');
    const semesterError = $('#semesterError');
    const yearError = $('#yearError');

    if (name.length < 1 || name.length > 244) {
      nameError.text('Module naam moet tussen de 4 en 100 karakters zijn.');
      nameError.addClass('d-block');
      return;
    }

    if (!description && description.length < 1500) {
      descriptionError.text('Vul alle verplichte velden in.');
      descriptionError.addClass('d-block');
      return;
    }

    if (cohort.length === 0) {
      descriptionError.text('Selecteer minimaal 1 cohort.');
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

    // check if the year in the year array are unique and between 1 and 4
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

    $('#submit').attr('disabled', 'disabled');

    const semesterItem = {
      name,
      description,
      semester,
      year: year,
      cohorts: [],
      cohortsId: cohortInt,
      requiredSemesterItemId: requiredSemesterItemInt,
      requiredSemesterItem: [],
      dependentSemesterItem: []
    };

    const success = await this.submitSemester(semesterItem);

    if (success) {
      Swal.fire('Module ' + semesterItem.name + ' Aangemaakt!', '', 'success');

      // Go back to the semester overview after a 3-second delay
      setTimeout(function () {
        $('#submit').attr('disabled', 'disabled');
        window.location.href = '/semester';
      }, 2000);
    } else {
      $('#submit').removeAttr('disabled');
      Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
    }
  }

  public async submitSemester(semesterItem: ISemester): Promise<boolean> {
    try {
      // Make the POST request to the server
      const response = await this.apiService.post<ISemester>('/api/semesterItem', semesterItem);
      return response !== undefined && response.name !== undefined;
    } catch (error) {
      return false;
    }
  }

}
