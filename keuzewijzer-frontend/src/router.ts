import { View } from './views/View';
import * as Handlebars from 'handlebars';
import * as fs from 'fs-extra';
import * as path from 'path';

export class Router {
  private routes: Map<string, View>;
  private currentView: View | null;

  constructor() {
    this.routes = new Map();
    this.currentView = null;
  }

  public addRoute(path: string, view: View): void {
    this.routes.set(path, view);
  }

  public start(): void {
    // Listen for changes to the URL
    window.addEventListener('popstate', () => {
      this.handleUrlChange(window.location.pathname);
    });

    // Handle the initial URL
    this.handleUrlChange(window.location.pathname);
  }

  private async handleUrlChange(path: string): Promise<void> {
    const view = this.routes.get(path);

    if (!view) {
      // If there is no matching view, show a 404 error
      this.show404();
      return;
    }

    // Load the partials dynamically
    await this.loadPartials();

    // Compile the view's template
    const template = Handlebars.compile(view.template);

    // Render the view
    const html = template(view.data);
    const app = document.getElementById('app');

    if (app) {
      app.innerHTML = html;
    }

    // Update the current view
    this.currentView = view;

    // Update the browser's history
    history.pushState({}, '', path);
  }

  private async loadPartials(): Promise<void> {
    const partialsDir = path.join(__dirname, 'templates/partials');
    const partials = await fs.readdir(partialsDir);

    for (const partial of partials) {
      const partialPath = path.join(partialsDir, partial);
      const partialContent = await fs.readFile(partialPath, 'utf8');
      const partialName = path.parse(partial).name;

      Handlebars.registerPartial(partialName, partialContent);
    }
  }

  private show404(): void {
    const app = document.getElementById('app');

    if (app) {
      app.innerHTML = '<h1>404 Error</h1><p>The page you requested could not be found.</p>';
    }
  }
}
