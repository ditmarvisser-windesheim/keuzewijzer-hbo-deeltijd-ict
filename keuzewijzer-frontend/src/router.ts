import * as Handlebars from 'handlebars';

import type AuthService from './services/AuthService';
import { type View } from './views/View';
import { registerHelpers } from './helpers/handlebars';
import SidebarPartial from './views/Partials/SidebarPartial';

export class Router {
  private readonly routes: Map<string, View>;
  private currentView: View | null;
  private authService: AuthService;
  private readonly sidebarPartial: SidebarPartial | undefined;

  constructor (authService: AuthService) {
    this.routes = new Map();
    this.currentView = null;
    this.authService = authService;
  }

  // Add route to the router
  public addRoute (path: string, view: View): void {
    this.routes.set(path, view);
  }

  // Add authenticated route to the router
  public addAuthenticatedRoute (path: string, view: View): void {
    this.routes.set(path, view);
  }

  public setAuthService (authService: AuthService): void {
    this.authService = authService;
  }

  public start (): void {
    registerHelpers();
    // Listen for changes to the URL
    window.addEventListener('popstate', () => {
      this.handleUrlChange(window.location.pathname).catch((error) => {
        console.log('Error handling initial URL: ', error);
      });
    });

    // Handle the initial URL
    this.handleUrlChange(window.location.pathname).catch((error) => {
      console.log('Error handling initial URL: ', error);
    });
  }

  private async handleUrlChange (path: string): Promise<void> {
    const app = document.getElementById('app');
    this.renderSidebar();

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
          this.currentView = routeView;
          this.currentView.authService = this.authService;
          this.currentView.params = params;
          break;
        }
      }
    }

    if (this.currentView == null) {
      // If there is no matching view, show a 404 error
      this.show404();
      return;
    }

    // Check if the route requires authentication
    if (this.currentView.requiresAuth !== null && this.currentView.requiresAuth !== undefined && !this.authService?.isAuthenticated()) {
      // If the user is not authenticated, redirect to the login page or show an error
      this.showAuthenticationError();
      return;
    }

    // Pass the authService instance to the view
    this.currentView.authService = this.authService;

    // Fetch the view's data from API project
    if (this.currentView.fetchAsyncData != null) {
      if (app != null) { // TODO: change if app
        app.innerHTML = '<h1>Loading...</h1>';
      }

      await this.currentView.fetchAsyncData().catch((error) => {
        console.log('Error fechting async data: ', error);
      });
    }

    // Compile the view's template
    const template = Handlebars.compile(this.currentView.template);

    // Render the view
    const html = template(this.currentView.data);

    if (app != null) {
      app.innerHTML = html;

      // Call the setup method of the view
      if (typeof this.currentView.setup === 'function') {
        this.currentView.setup();
      }
    }

    // Update the browser's history
    history.pushState({}, '', path);
  }

  private renderSidebar (): void {
    const sidebarContainer = document.getElementById('sidebar-container');

    if (sidebarContainer != null) {
      const isAuthenticated = this.authService.isAuthenticated();
      const userData = this.authService.getUserData();

      const sidebarData = {
        isAuthenticated: isAuthenticated,
        userData: userData
      };

      // Create a new instance of SidebarPartial with user data
      var sidebar = new SidebarPartial(this.authService, userData);
      sidebar.setup();

      // Render the sidebar HTML
      const sidebarTemplate = Handlebars.compile(sidebar.template);
      const sidebarHtml = sidebarTemplate(sidebarData);

      // Append the sidebar HTML to the sidebar container
      sidebarContainer.innerHTML = sidebarHtml;
    }
  }

  private show404 (): void {
    const app = document.getElementById('app');

    if (app != null) {
      app.innerHTML = '<h1>404 Error</h1><p>The page you requested could not be found.</p>';
    }
  }

  private showAuthenticationError (): void {
    const app = document.getElementById('app');

    if (app != null) {
      app.innerHTML = '<h1>Authentication Error</h1><p>You need to log in to access this page.</p>';
    }
  }
}
