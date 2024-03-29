import Swal from 'sweetalert2';

import { type View } from '../View';
import { type ApiService } from 'services/ApiService';
import { type ISemester } from 'interfaces/iSemester';

export class SemesterIndexView implements View {
  public apiService!: ApiService;

  public template = `
    <div class="container mt-2">
      <div class="row">
        <div class="col-9">
          <h1>Module</h1>
        </div>
        <div class="col-3 d-flex justify-content-end">
          <a href="/semester/create" data-link class="btn btn-primary btn-lg active" role="button" aria-pressed="true">Module aanmaken</a>
        </div>
      </div>  

      <table class="table">
        <thead>
          <tr>
            <th scope="col">Naam</th>
            <th scope="col">Beschrijving</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="semesterItems">
          <div id="loading" class="d-flex justify-content-center">
            <div class="spinner-border" role="status">
              <span class="sr-only"></span>
            </div>
          </div>        
        </tbody>
      </table>
    </div>
  `;

  public data = {};

  public async setup (): Promise<void> {
    try {
      const study_semesters = await this.apiService.get<ISemester[]>('/api/semesterItem');

      $('#loading').remove();

      if (Array.isArray(study_semesters)) {
        study_semesters.forEach((semester) => {
          const tableBody = document.getElementById('semesterItems');
          if (tableBody != null && semester.id != null) {
            const row = $('<tr>').append(
              $('<td>').text(semester.name),
              $('<td>').text(semester.description),
              $('<td>').append(
                $('<a>').attr('href', '/semester/update/' + semester.id)
                  .addClass('btn btn-primary btn-sm active')
                  .attr('role', 'button')
                  .attr('aria-pressed', 'true')
                  .text('Bewerken'),
                $('<button>').addClass('btn btn-danger btn-sm active delete-button')
                  .attr('data-id', semester.id)
                  .text('Verwijderen')
              )
            );
            row.appendTo(tableBody);
          }
        });
      } else {
        console.error('Study semesters is not an array');
      }
    } catch (error) {
      console.error('Error fetching study semesters:', error);
    }

    const deleteButtons = document.querySelectorAll('.delete-button');
    deleteButtons.forEach((button) => {
      button.addEventListener('click', async (event) => { await this.handleDeleteButtonClick(event); });
    });
  }

  private async handleDeleteButtonClick (event: Event): Promise<void> {
    try {
      const button = event.target as HTMLButtonElement;
      const moduleId = button.dataset.id;
      if (moduleId) {
        const result = await Swal.fire({
          title: 'Weet u het zeker?',
          text: 'U staat op het punt om deze module te verwijderen',
          icon: 'warning',
          showCancelButton: true,
          confirmButtonText: 'Ja, verwijderen!',
          cancelButtonText: 'Annuleren'
        });
        if (result.isConfirmed) {
          // Make the API call to delete the module
          const response = await this.apiService.delete(`/api/semesterItem/${moduleId}`);
          if (response.status === 204) {
            // Success! Remove the corresponding row from the table
            const row = button.closest('tr');
            if (row != null) {
              row.remove();
            }
            Swal.fire('Verwijderd!', 'De module is verwijderd.', 'success');
          } else {
            // Error occurred while deleting the module
            Swal.fire('Fout!', 'Er is een fout opgetreden bij het verwijderen van de module.', 'error');
          }
        }
      }
    } catch (error) {
      console.error('Error handling delete button click:', error);
      Swal.fire('Fout!', 'Er is een fout opgetreden.', 'error');
    }
  }
}
