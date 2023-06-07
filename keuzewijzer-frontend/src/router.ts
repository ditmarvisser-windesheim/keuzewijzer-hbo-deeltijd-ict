import * as Handlebars from 'handlebars';

import AuthService from './services/AuthService';
import { View } from './views/View';
import { registerHelpers } from './helpers/handlebars';
import SidebarPartial from './views/Partials/SidebarPartial';

export class Router {
  private routes: Map<string, View>;
  private currentView: View | null;
  private authService: AuthService;
  sidebarPartial: SidebarPartial;

  constructor(authService: AuthService) {
    this.routes = new Map();
    this.currentView = null;
    this.authService = authService;
  }

  // Add route to the router
  public addRoute(path: string, view: View): void {
    this.routes.set(path, view);
  }

  // Add authenticated route to the router
  public addAuthenticatedRoute(path: string, view: View): void {
    this.routes.set(path, view);
  }

  public setAuthService(authService: AuthService): void {
    this.authService = authService;
  }

  public start(): void {
    registerHelpers();
    // Listen for changes to the URL
    window.addEventListener('popstate', () => {
      this.handleUrlChange(window.location.pathname);
    });

    // Handle the initial URL
    this.handleUrlChange(window.location.pathname);
  }

  private async handleUrlChange(path: string): Promise<void> {
    let view: View | undefined;
    const app = document.getElementById('app');

    // Iterate over the routes and find a match
    const urlParts = path.split('/');

    // Iterate over the routes and find a match
    for (const [route, routeView] of this.routes) {
      const routeParts = route.split('/');
      if (routeParts.length === urlParts.length) {
        let match = true;
        const params: Record<string, string> = {};

        for (let i = 0; i < routeParts.length; i++) {
          if (routeParts[i].startsWith(':')) {
            params[routeParts[i].slice(1)] = urlParts[i];
          } else if (routeParts[i] !== urlParts[i]) {
            match = false;
            break;
          }
        }

        if (match) {
          view = routeView;
          view.params = params;
          break;
        }
      }
    }

    if (!view) {
      // If there is no matching view, show a 404 error
      this.show404();
      return;
    }

    // Check if the route requires authentication
    if (view.requiresAuth && !this.authService.isAuthenticated()) {
      // If the user is not authenticated, redirect to the login page or show an error
      this.showAuthenticationError();
      return;
    }

    // Pass the authService instance to the view
    view.authService = this.authService;

    // Fetch the view's data from API project
    if (view.fetchAsyncData) {
      if (app) { // TODO: change if app
        app.innerHTML = '<h1>Loading...</h1>';
      }
      await view.fetchAsyncData();
    }

    // Compile the view's template
    const template = Handlebars.compile(view.template);

    // Render the view
    const html = template(view.data);

    if (app) {
      app.innerHTML = html;

      // Call the setup method of the view 
      if (typeof view.setup === 'function') {
        view.setup();
      }
    }

    // Update the current view
    this.currentView = view;

    // Update the browser's history
    history.pushState({}, '', path);
  }

  private renderSidebar(): void {
    const sidebarContainer = document.getElementById('sidebar-container');

    if (sidebarContainer) {
      const userData = this.authService.getUserData();

      if (userData) {
        // Create a new instance of SidebarPartial with user data
        this.sidebarPartial = new SidebarPartial(userData);

        // Render the sidebar HTML
        const sidebarHtml: string = this.sidebarPartial.render();

        // Append the sidebar HTML to the sidebar container
        sidebarContainer.innerHTML = sidebarHtml;
      } else {
        // Clear the sidebar container if user data is not available
        sidebarContainer.innerHTML = '';
      }
    }
  }

  private show404(): void {
    const app = document.getElementById('app');

    if (app) {
      app.innerHTML = '<h1>404 Error</h1><p>The page you requested could not be found.</p>';
    }
  }

  private showAuthenticationError(): void {
    const app = document.getElementById('app');

    if (app) {
      app.innerHTML = '<h1>Authentication Error</h1><p>You need to log in to access this page.</p>';
    }
  }
}