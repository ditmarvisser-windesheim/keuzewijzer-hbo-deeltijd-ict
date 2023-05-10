import { Router } from './router';
import { HomeView } from './views/HomeView';

export class App {
  private router: Router;
  
  constructor() {
    this.router = new Router();

    // Add routes to the router
    this.router.addRoute('/', new HomeView());
    
    // Start the router
    this.router.start();
  }
}