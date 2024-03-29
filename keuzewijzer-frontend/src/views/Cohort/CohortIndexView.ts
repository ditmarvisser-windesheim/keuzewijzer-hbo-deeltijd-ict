import Swal from 'sweetalert2';

import { type View } from '../View';
import { type ApiService } from 'services/ApiService';
import { type ICohort } from 'interfaces/iCohort';

export class CohortIndexView implements View {
  public apiService!: ApiService;

  public template = `
    <div class="container mt-2">
      <div class="row">
        <div class="col-9">
          <h1>Cohorts</h1>
        </div>
        <div class="col-3 d-flex justify-content-end">
          <a href="/cohort/create" data-link class="btn btn-primary btn-lg active" role="button" aria-pressed="true">Cohort aanmaken</a>
        </div>
      </div>  

      <table class="table">
        <thead>
          <tr>
            <th scope="col">Name</th>
            <th scope="col">Year</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="cohorts">
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

  public async setup(): Promise<void> {
    try {
      const cohorts = await this.apiService.get<ICohort[]>('/api/Cohort');
      $('#loading').remove();

      if (Array.isArray(cohorts)) {
        cohorts.forEach((cohort) => {
          const tableBody = document.getElementById('cohorts');
          if (tableBody != null && cohort.id != null) {
            const row = $('<tr>').append(
              $('<td>').text(cohort.name),
              $('<td>').text(cohort.year),
              $('<td>').append(
                $('<button>').addClass('btn btn-danger btn-sm active delete-button')
                  .attr('data-id', cohort.id)
                  .text('Verwijderen')
              )
            );
            row.appendTo(tableBody);
          }
        });
      } else {
        console.error('Cohort is not an array');
      }
    } catch (error) {
      console.error('Error fetching cohorts:', error);
    }

    const deleteButtons = document.querySelectorAll('.delete-button');
    deleteButtons.forEach((button) => {
      button.addEventListener('click', async (event) => { await this.handleDeleteButtonClick(event); });
    });
  }

  private async handleDeleteButtonClick(event: Event): Promise<void> {
    try {
      const button = event.target as HTMLButtonElement;
      const cohortId = button.dataset.id;
      if (cohortId) {
        const result = await Swal.fire({
          title: 'Weet u het zeker?',
          text: 'U staat op het punt om deze cohort te verwijderen',
          icon: 'warning',
          showCancelButton: true,
          confirmButtonText: 'Ja, verwijderen!',
          cancelButtonText: 'Annuleren'
        });
        if (result.isConfirmed) {
          // Make the API call to delete the module
          const response = await this.apiService.delete(`/api/Cohort/${cohortId}`);
          if (response.status === 204) {
            // Success! Remove the corresponding row from the table
            const row = button.closest('tr');
            if (row != null) {
              row.remove();
            }
            Swal.fire('Verwijderd!', 'De cohort is verwijderd.', 'success');
          } else {
            // Error occurred while deleting the module
            Swal.fire('Fout!', 'Er is een fout opgetreden bij het verwijderen van de cohort.', 'error');
          }
        }
      }
    } catch (error) {
      console.error('Error handling delete button click:', error);
      Swal.fire('Fout!', 'Er is een fout opgetreden.', 'error');
    }
  }
}
function getAllCohorts () {
  throw new Error('Function not implemented.');
}
