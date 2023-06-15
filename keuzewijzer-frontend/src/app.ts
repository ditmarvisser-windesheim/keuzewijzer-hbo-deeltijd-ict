import { Router } from './router';
import AuthService from './services/AuthService';

// Import views
import { HomeView } from './views/HomeView';
import { SemesterCreateView } from './views/Module/SemesterCreateView';
import { SemesterUpdateView } from './views/Module/SemesterUpdateView';
import { SemesterIndexView } from './views/Module/SemesterIndexView';
import { CohortIndexView } from './views/Cohort/CohortIndexView';
import { CohortCreateView } from './views/Cohort/CohortCreateView';
import { UserIndexView } from './views/User/UserIndexView';
import { UserUpdateRoleView } from './views/User/UserUpdateRoleView';
import { UserUpdateSemesterView } from './views/User/UserUpdateSemesterView';
import { StudentsIndexView } from './views/Students/StudentsIndexView';

import { LoginView } from './views/Auth/LoginView';

export class App {
  private readonly router: Router;
  private readonly authService: AuthService;

  constructor () {
    this.authService = new AuthService();
    this.router = new Router(this.authService);

    // Add routes to the router
    this.router.addRoute('/', new HomeView());

    // SemesterItem
    this.router.addRoute('/semester', new SemesterIndexView());
    this.router.addRoute('/semester/create', new SemesterCreateView());
    this.router.addRoute('/semester/update/:id', new SemesterUpdateView());

    // Cohort
    this.router.addRoute('/cohort', new CohortIndexView());
    this.router.addRoute('/cohort/create', new CohortCreateView());

    // Users
    this.router.addRoute('/user', new UserIndexView());
    this.router.addRoute('/user/update/:id', new UserUpdateRoleView())
    this.router.addRoute('/user/update/semester/:id', new UserUpdateSemesterView());

    // Login
    this.router.addRoute('/login', new LoginView());

    //Students
    this.router.addRoute('/students/:id', new StudentsIndexView())

    // Start the router
    this.router.start();
  }
}
