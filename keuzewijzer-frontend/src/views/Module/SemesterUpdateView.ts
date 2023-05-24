import { View } from '../View';
import Swal from 'sweetalert2';

export class SemesterUpdateView implements View {
  public module = {
    Id: 1,
    Name: 'Module 1',
    Description: 'This is the first module',
  };

  public template = `
    <div class="container mt-2 mb-2">
      <div class="row">
        <div class="col-3 d-flex justify-content-start">
            <a href="/module" data-link class="btn btn-secondary btn-lg active" role="button" aria-pressed="true">Terug</a>
        </div>
        <div class="col-9">
          <h1>Module bijwerken</h1>
        </div>
      </div>
      
      <form id="module-form">
        <div class="form-group">
          <label for="name">Naam:</label>
          <input type="text" class="form-control" id="name" value="{{current_module.Name}}">
          <div id="nameError" class="invalid-feedback"></div>
        </div>
        <div class="form-group">
          <label for="description">Beschrijving:</label>
          <textarea class="form-control" id="description" rows="3">{{current_module.Description}}</textarea>
          <div id="descriptionError" class="invalid-feedback"></div>
        </div>
        <button type="submit" class="btn btn-primary">Bijwerken</button>
      </form>
    </div>
  `;

  public data = {
    current_module: this.module,
  };

  public setup(): void {
    console.log('ModuleUpdate.setup()');

    const moduleForm = document.getElementById('module-form') as HTMLFormElement;
    moduleForm.addEventListener('submit', this.handleModuleUpdate.bind(this));
  }

  private handleModuleUpdate(event: Event): void {
    event.preventDefault();
    const nameInput = document.getElementById('name') as HTMLInputElement;
    const descriptionInput = document.getElementById('description') as HTMLTextAreaElement;
    const currentModule = this.data.current_module;
    const name = nameInput.value;
    const description = descriptionInput.value;

    const nameError = document.getElementById('nameError')!;
    const descriptionError = document.getElementById('descriptionError')!;

    if (currentModule && name.length >= 4 && name.length <= 100 && description) {
      // Perform the module update logic here
      console.log('Module bijwerken...');
      console.log('Module:', currentModule);
      console.log('Naam:', name);
      console.log('Beschrijving:', description);

      // Show a success message
      Swal.fire('Module Bijgewerkt!', 'De module is bijgewerkt.', 'success');

      // Reset the form inputs
      nameInput.value = '';
      descriptionInput.value = '';

      // Clear error messages
      nameError.textContent = '';
      descriptionError.textContent = '';

      // Hide error messages
      nameError.classList.remove('d-block');
      descriptionError.classList.remove('d-block');
    } else {
      if (!currentModule) {
        Swal.fire('Fout!', 'Huidige module niet gevonden.', 'error');
      }

      if (name.length < 4 || name.length > 100) {
        nameError.textContent = 'Module naam moet tussen de 4 en 100 karakters zijn.';
        nameError.classList.add('d-block');
      }

      if (!description) {
        descriptionError.textContent = 'Vul alle verplichte velden in.';
        descriptionError.classList.add('d-block');
      }
    }
  }
}
