import { View } from '../View';
import Api from '../../js/api/api';
import Swal from 'sweetalert2';
import {User} from '../../../Models/User'
import { Role } from '../../../Models/Role';

export class StudentsIndexView implements View {
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
            <th scope="col">Student</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="students">
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
      var students = await Api.get(`/api/User/students/${this.params?.id}`);
      console.log(students);
      
      
      if (Array.isArray(students)) {
        students.forEach(async (student) => {
          // var roles = await Api.get(`/api/User/${user.id}/roles`)
          // var rolesText = '';
          // if (Array.isArray(roles)) {
          //   rolesText = roles.toString();
          // }
          var tableBody = document.getElementById('students');
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
          } else {
            console.error('Users is not an array');
          }
        } catch (error) {
          console.error('Error fetching users:', error);
        }
      $('#loading').remove();
        

  }
}
