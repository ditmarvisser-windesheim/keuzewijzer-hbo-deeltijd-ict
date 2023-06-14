import { type View } from '../View';
import { getAllUsers } from '../../api/user';
import { Role } from '../../../Models/Role';

export class UserIndexView implements View {
  public template = `
    <div class="container mt-2">
      <div class="row">
        <div class="col-9">
          <h1>Gebruikers</h1>
        </div>
      </div>  

      <table class="table">
        <thead>
          <tr>
            <th scope="col">Name</th>
            <th scope="col">Rollen</th>
            <th scope="col">Acties</th>
          </tr>
        </thead>
        <tbody id="users">
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
      const users = await getAllUsers();
      
      if (Array.isArray(users)) {
        users.forEach(async (user) => {
          var roles = await Api.get(`/api/User/${user.id}/roles`)
          var rolesText = '';
          if (Array.isArray(roles)) {
            rolesText = roles.toString();
          }
          const tableBody = document.getElementById('users');
          if (tableBody != null) {
            const row = $('<tr>').append(
              $('<td>').text(user.name),
              $('<td>').text(rolesText),
              $('<td>').append(
                $('<a>').attr('href', '/user/update/' + user.id)
                .addClass('btn btn-primary btn-sm active')
                  .attr('role', 'button')
                  .attr('aria-pressed', 'true')
                  .text('Rollen aanpassen'),
                $('<a>').attr('href', '/user/update/semester/' + user.id)
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
