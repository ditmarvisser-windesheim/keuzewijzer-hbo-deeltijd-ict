import { Router } from './router';
import { HomeView } from './views/HomeView';
import { UserIndexView } from './views/User/UserIndexView';
import { UserUpdateView } from 'views/User/UserUpdateView';

export class App {
  private router: Router;
  
  constructor() {
    this.router = new Router();

    // Add routes to the router
    this.router.addRoute('/', new HomeView());

    // User control
    this.router.addRoute('/usercontrol', new UserIndexView())
    this.router.addRoute('/userUpdate', new UserUpdateView())
    
    // Start the router
    this.router.start();
  }
}