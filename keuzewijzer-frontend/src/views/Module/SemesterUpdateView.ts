import Swal from 'sweetalert2';

import { type View } from '../View';
import { type ICohort } from 'interfaces/iCohort';
import { type ISemester } from 'interfaces/iSemester';
import { type ApiService } from 'services/ApiService';

export class SemesterUpdateView implements View {
  public apiService!: ApiService;

  public params: Record<string, string> = {};

  public template = `
  <div class="container mt-2 mb-2">
    <div class="row">
      <div class="col-3 d-flex justify-content-start">
        <a href="/semester" data-link class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">Terug</a>
      </div>
      <div class="col-9">
        <h1>Module aanpassen</h1>
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
      <button type="submit" class="btn btn-primary">Aanpassen</button>
    </form>
  </div>
`;

  public data = {};

  public async setup (): Promise<void> {
    await this.updateRequiredSemesterItem();
    await this.updateCohorts();

    this.setForm();

    const semesterForm = $('#semester-form');
    semesterForm.on('submit', this.handleSemesterUpdate.bind(this));
  }

  private async updateCohorts (): Promise<void> {
    const cohortSelect = $('#cohorts');
    const cohorts = await this.apiService.get<ICohort[]>('/api/cohort');

    cohorts.forEach((cohort: ICohort) => {
      cohortSelect.append(`<option value="${cohort.id}">${cohort.name}</option>`);
    });
  }

  private async updateRequiredSemesterItem (): Promise<void> {
    const requiredSemesterItemSelect = $('#requiredSemesterItem');
    const requiredSemesterItem = await this.apiService.get<ISemester[]>('/api/semesterItem');

    requiredSemesterItem.forEach((semesterItem: ISemester) => {
      if (semesterItem.id !== null && semesterItem.id !== undefined) {
        if (semesterItem.id.toString() === this.params?.id ?? '-1') return;
        requiredSemesterItemSelect.append(`<option value="${semesterItem.id}">${semesterItem.name}</option>`);
      }
    });
  }

  private async setForm (): Promise<void> {
    const id = this.params?.id;

    const response = await this.apiService.get<ISemester>(`/api/semesterItem/${id}`);

    if ('status' in response && response.status === 404) {
      Swal.fire({
        title: 'Fout!',
        text: 'Module niet gevonden!',
        icon: 'error',
        confirmButtonText: 'Oké'
      });

      setTimeout(() => {
        window.location.href = '/semester';
      }, 2000);

      return;
    }

    if (response && response.id !== null && response.id !== undefined) {
      // set the values of the form
      $('#name').val(response.name);
      $('#description').val(response.description);
      $('#semester').val(response.semester);
      $('#id').val(response.id.toString());
    }

    const yearSelect = $('#year');
    const selectedYearValues = response.year.map(String); // Convert numbers to strings
    yearSelect.val(selectedYearValues);

    // Set the required semester items
    const requiredSemesterItemSelect = $('#requiredSemesterItem');
    const selectedRequiredSemesterItemValues: string[] = []; // Initialize as an empty array

    if (response.requiredSemesterItem !== null) {
      response.requiredSemesterItem.forEach((semesterItem: ISemester) => {
        if (semesterItem.id !== null && semesterItem.id !== undefined) {
          selectedRequiredSemesterItemValues.push(semesterItem.id.toString());
        }
      });
    }

    requiredSemesterItemSelect.val(selectedRequiredSemesterItemValues);

    // Set the cohorts
    const cohortSelect = $('#cohorts');
    const selectedCohortValues: string[] = []; // Initialize as an empty array

    if (response.cohorts !== null) {
      response.cohorts.forEach((cohort: ICohort) => {
        if (cohort.id !== null && cohort.id !== undefined) {
          selectedCohortValues.push(cohort.id.toString());
        }
      });
    }

    cohortSelect.val(selectedCohortValues);
  }

  private async handleSemesterUpdate (event: Event): Promise<void> {
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

    if (name.length < 1 || name.length > 100) {
      nameError.text('Semester item naam moet tussen de 1 en 100 karakters zijn.');
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

    const semesterItem: ISemester = {
      id,
      name,
      description,
      semester,
      year,
      cohorts: [],
      cohortsId: cohortInt,
      requiredSemesterItemId: requiredSemesterItemInt,
      requiredSemesterItem: [],
      dependentSemesterItem: []
    };

    try {
      // Make the POST request to the server
      const response = await this.apiService.put<ISemester>(`/api/semesterItem/${id}`, semesterItem);
      if (response.name === undefined) {
        Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
        return;
      }

      // Show a success message
      Swal.fire('Module ' + response.name + ' Aangepast!', '', 'success');

      // Go back to the semester overview wait for 3 seconds
      setTimeout(function () {
        window.location.href = '/semester';
      }, 2000);
    } catch (error) {
      Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
    }
  }
}
