import { View } from '../View';
import Swal from 'sweetalert2';
import { Semester } from 'Models/Semester';
import Api from '../../js/api/api';

export class SemesterCreateView implements View {
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
        <button type="submit" class="btn btn-primary">Aanmaken</button>
      </form>
    </div>
  `;

  public data = {};

  public setup(): void {
    console.log('SemesterCreate.setup()');

    const semesterForm = document.getElementById('semester-form') as HTMLFormElement;
    semesterForm.addEventListener('submit', this.handleSemesterCreate.bind(this));
  }

  private async handleSemesterCreate(event: Event): Promise<void> {
    event.preventDefault();
    const nameInput = document.getElementById('name') as HTMLInputElement;
    const descriptionInput = document.getElementById('description') as HTMLTextAreaElement;
    const semesterInput = document.getElementById('semester') as HTMLInputElement;
    const name = nameInput.value;
    const description = descriptionInput.value;
    const semester = parseInt(semesterInput.value);

    const nameError = document.getElementById('nameError')!;
    const descriptionError = document.getElementById('descriptionError')!;
    const semesterError = document.getElementById('semesterError')!;

    if (name.length < 4 || name.length > 100) {
      nameError.textContent = 'Semester item naam moet tussen de 4 en 100 karakters zijn.';
      nameError.classList.add('d-block');
      return;
    }

    if (!description) {
      descriptionError.textContent = 'Vul alle verplichte velden in.';
      descriptionError.classList.add('d-block');
      return;
    }

    if (semester < 1 || semester > 2) {
      semesterError.textContent = 'Semester moet een waarde tussen 1 en 2 hebben.';
      semesterError.classList.add('d-block');
      return;
    }

    const semesterItem = {
      name: name,
      description: description,
      semester: semester,
      Year: [], // Add the required Year field
      Cohorts: [], // Add the required Cohorts field
      RequiredSemesterItem: [], // Add the required RequiredSemesterItem field
      DependentSemesterItem: [] // Add the required DependentSemesterItem field
    };

    try {
      // Make the POST request to the server
      const response = await Api.post('/api/semesterItem', semesterItem);

      if (response.ok) {
        // Show a success message
        Swal.fire('Semester Item Aangemaakt!', 'Het semester item is aangemaakt.', 'success');

        // Reset the form inputs
        nameInput.value = '';
        descriptionInput.value = '';
        semesterInput.value = '';

        // Clear error messages
        nameError.textContent = '';
        descriptionError.textContent = '';
        semesterError.textContent = '';

        // Hide error messages
        nameError.classList.remove('d-block');
        descriptionError.classList.remove('d-block');
        semesterError.classList.remove('d-block');
      } else {
        Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
      }
    } catch (error) {
      Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
    }
  }
}
