import { View } from '../View';
import { ApiService } from 'services/ApiService';
import Swal from 'sweetalert2';
import { IUser } from 'interfaces/iUser';

export class StudentsIndexView implements View {
  public apiService!: ApiService;
  public params: Record<string, string> = {};
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
            <th scope="col">Studieroutes goedgekeurd, afgekeurd door StudieVoortgang</th>
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

  public async setup(): Promise<void> {
    try {
      var students = await this.apiService.get<IUser[]>(`/api/User/students/${this.params?.id}`);

      if (Array.isArray(students)) {
        var routesApprovedBySV = 0;
        var routesRejectedBySV = 0;
        var routesRejectedBySB = 0;
        var routesApprovedWaitingForSV = 0;
        var routesToApprove = 0;
        var routesOther = 0;
        students.forEach(async (student) => {
          var tableBody;
          if (student.studyRoute.approved_eb == true){
            tableBody = document.getElementById('routesApprovedBySV');
            routesApprovedBySV++;
          } else if (student.studyRoute.approved_eb == false){
            tableBody = document.getElementById('routesRejectedBySV');
            routesRejectedBySV++;
          } else if (student.studyRoute.approved_sb == false){
            tableBody = document.getElementById('routesRejectedBySB');
            routesRejectedBySB++;
          } else if (student.studyRoute.send_eb == true){
            tableBody = document.getElementById('routesApprovedWaitingForSV');
            routesApprovedWaitingForSV++;
          } else if (student.studyRoute.send_sb == true){
            tableBody = document.getElementById('routesToApprove');
            routesToApprove++;
          } else {
            tableBody = document.getElementById('routesOther');
            routesOther++;
          }

          if (tableBody) {
            var row = $('<tr>').append(
              $('<td>').text(student.name),
              $('<td>').append(
                $('<a>').attr('href', '/user/update/semester/' + student.id)
                .addClass('btn btn-primary btn-sm active')
                .attr('role', 'button')
                .attr('aria-pressed', 'true')
                .text('Semester toewijzen')
                )
                )
                
                row.appendTo(tableBody);
              }
            });
        
        var tableBody;
        
        if(!routesApprovedBySV){
          tableBody = document.getElementById('routesApprovedBySV')!;
          var row = $('<tr>').append(
            $('<td>').text("Er zijn geen studieroutes goedgekeurd door StudieVoortgang").addClass("text-center"),
            $('<td>').text("")
              )
          row.appendTo(tableBody);
        }
        if(!routesRejectedBySV){
          tableBody = document.getElementById('routesRejectedBySV')!;
          var row = $('<tr>').append(
            $('<td>').text("Er zijn geen studieroutes afgekeurd door StudieVoortgang").addClass("text-center"),
            $('<td>').text("")
              )
          row.appendTo(tableBody);
        }
        if(!routesRejectedBySB){
          tableBody = document.getElementById('routesRejectedBySB')!;
          var row = $('<tr>').append(
            $('<td>').text("Er zijn geen studieroutes afgekeurd door de Studiebegeleider").addClass("text-center"),
            $('<td>').text("")
              )
          row.appendTo(tableBody);
        }
        if(!routesApprovedWaitingForSV){
          tableBody = document.getElementById('routesApprovedWaitingForSV')!;
          var row = $('<tr>').append(
            $('<td>').text("Er zijn geen studieroutes die wachten op beoordeling door StudieVoortgang").addClass("text-center"),
            $('<td>').text("")
              )
          row.appendTo(tableBody);
        }
        if(!routesToApprove){
          tableBody = document.getElementById('routesToApprove')!;
          var row = $('<tr>').append(
            $('<td>').text("Er zijn geen studieroutes die wachten op beoordeling door de Studiebegeleider").addClass("text-center"),
            $('<td>').text("")
              )
          row.appendTo(tableBody);
        }
        if(!routesOther){
          tableBody = document.getElementById('routesOther')!;
          var row = $('<tr>').append(
            $('<td>').text("Er zijn geen studieroutes die nog niet zijn opgestuurd voor beoordeling").addClass("text-center"),
            $('<td>').text("")
              )
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
