import { View } from './View';
import Api from '../js/api/api';
import { template } from 'handlebars';

export class HomeView implements View {
  public study_modules = Api.get('/study_modules');

  public template = `
    <h1>Welcome to my SPA</h1>
    <p>Click a link above to navigate</p>
  `;

  public data = {};

  public setup(): void {
    console.log('HomeView.setup()');
  }
}
