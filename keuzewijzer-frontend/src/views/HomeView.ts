import { View } from './View';

export class HomeView implements View {
  public template = `
    <h1>Welcome to my SPA</h1>
    <p>Click a link above to navigate</p>
  `;

  public data = {};
}
