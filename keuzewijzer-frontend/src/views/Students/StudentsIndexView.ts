import { type View } from '../View';
import { type ApiService } from 'services/ApiService';
import Swal from 'sweetalert2';
import { type IUser } from 'interfaces/iUser';
import type AuthService from 'services/AuthService';

export class StudentsIndexView implements View {
  public apiService!: ApiService;
  public params: Record<string, string> = {};
  public authService!: AuthService;
  public template = `
    <div class="container mt-2">
      <div class="row">
        <div class="col-9">
          <h1>Mijn studenten</h1>
        </div>
      </div>  

      <table class="table">
        <thead>
          <tr>
            <th scope="col">Studieroutes om te beoordelen</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="routesToApprove">
          <div class="d-flex justify-content-center loading">
            <div class="spinner-border" role="status">
              <span class="sr-only"></span>
            </div>
          </div>        
        </tbody>
        
        <thead>
          <tr>
            <th scope="col">Studieroutes afgekeurd door StudieVoortgang</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="routesRejectedBySV">
          </div>        
        </tbody>
        
        <thead>
          <tr>
            <th scope="col">Studieroutes goedgekeurd, wachten op StudieVoortgang</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="routesApprovedWaitingForSV">
          <div class="d-flex justify-content-center loading">
          </div>        
        </tbody>
        
        <thead>
          <tr>
            <th scope="col">Studieroutes afgekeurd door studiebegeleider</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="routesRejectedBySB">
          <div class="d-flex justify-content-center loading">
          </div>        
        </tbody>

        <thead>
          <tr>
            <th scope="col">Studieroutes goedgekeurd door StudieVoortgang</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="routesApprovedBySV">
          <div class="d-flex justify-content-center loading">
          </div>        
        </tbody>

        <thead>
          <tr>
            <th scope="col">Overige studieroutes</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="routesOther">
          <div class="d-flex justify-content-center loading">
          </div>        
        </tbody>

      </table>
    </div>
  `;

  public data = {};

  public async setup (): Promise<void> {
    try {
      const students = await this.apiService.get<IUser[]>(`/api/User/students/${this.authService.getUserData()!.userId}`);

      if (Array.isArray(students)) {
        let routesApprovedBySV = 0;
        let routesRejectedBySV = 0;
        let routesRejectedBySB = 0;
        let routesApprovedWaitingForSV = 0;
        let routesToApprove = 0;
        let routesOther = 0;
        students.forEach(async (student) => {
          let tableBody;
          let button = $();

          if (student.studyRoute.approved_eb == true) {
            tableBody = document.getElementById('routesApprovedBySV');
            routesApprovedBySV++;
          } else if (student.studyRoute.approved_eb == false) {
            tableBody = document.getElementById('routesRejectedBySV');
            routesRejectedBySV++;
            button = $('<a>').addClass('btn btn-danger btn-sm active reminder')
              .attr('role', 'button')
              .attr('aria-pressed', 'true')
              .text('Reminder sturen');
          } else if (student.studyRoute.approved_sb == false) {
            tableBody = document.getElementById('routesRejectedBySB');
            routesRejectedBySB++;
            button = $('<a>').addClass('btn btn-warning btn-sm active reminder')
              .attr('role', 'button')
              .attr('aria-pressed', 'true')
              .text('Reminder sturen');
          } else if (student.studyRoute.send_eb == true) {
            tableBody = document.getElementById('routesApprovedWaitingForSV');
            routesApprovedWaitingForSV++;
          } else if (student.studyRoute.send_sb) {
            tableBody = document.getElementById('routesToApprove');
            routesToApprove++;
            button = $('<a>').attr('href', '/students/studyroute/' + student.id)
              .addClass('btn btn-success btn-sm active')
              .attr('role', 'button')
              .attr('aria-pressed', 'true')
              .text('Studieroute bekijken');
          } else {
            tableBody = document.getElementById('routesOther');
            routesOther++;
            button = $('<a>').addClass('btn btn-warning btn-sm active reminder')
              .attr('role', 'button')
              .attr('aria-pressed', 'true')
              .text('Reminder sturen');
          }

          if (tableBody != null) {
            const row = $('<tr>').append(
              $('<td>').text(student.name),
              $('<td>').append(
                button
              )
            );

            row.appendTo(tableBody);
          }
        });

        let tableBody;

        if (!routesApprovedBySV) {
          tableBody = document.getElementById('routesApprovedBySV')!;
          var row = $('<tr>').append(
            $('<td>').text('Er zijn geen studieroutes goedgekeurd door StudieVoortgang').addClass('text-center'),
            $('<td>').text('')
          );
          row.appendTo(tableBody);
        }
        if (!routesRejectedBySV) {
          tableBody = document.getElementById('routesRejectedBySV')!;
          var row = $('<tr>').append(
            $('<td>').text('Er zijn geen studieroutes afgekeurd door StudieVoortgang').addClass('text-center'),
            $('<td>').text('')
          );
          row.appendTo(tableBody);
        }
        if (!routesRejectedBySB) {
          tableBody = document.getElementById('routesRejectedBySB')!;
          var row = $('<tr>').append(
            $('<td>').text('Er zijn geen studieroutes afgekeurd door de Studiebegeleider').addClass('text-center'),
            $('<td>').text('')
          );
          row.appendTo(tableBody);
        }
        if (!routesApprovedWaitingForSV) {
          tableBody = document.getElementById('routesApprovedWaitingForSV')!;
          var row = $('<tr>').append(
            $('<td>').text('Er zijn geen studieroutes die wachten op beoordeling door StudieVoortgang').addClass('text-center'),
            $('<td>').text('')
          );
          row.appendTo(tableBody);
        }
        if (!routesToApprove) {
          tableBody = document.getElementById('routesToApprove')!;
          var row = $('<tr>').append(
            $('<td>').text('Er zijn geen studieroutes die wachten op beoordeling door de Studiebegeleider').addClass('text-center'),
            $('<td>').text('')
          );
          row.appendTo(tableBody);
        }
        if (!routesOther) {
          tableBody = document.getElementById('routesOther')!;
          var row = $('<tr>').append(
            $('<td>').text('Er zijn geen studieroutes die nog niet zijn opgestuurd voor beoordeling').addClass('text-center'),
            $('<td>').text('')
          );
          row.appendTo(tableBody);
        }
      } else {
        console.error('Users is not an array');
      }
    } catch (error) {
      console.error('Error fetching users:', error);
    }
    $('.loading').remove();
  }
}
