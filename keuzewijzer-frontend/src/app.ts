import { Router } from './router';
import { HomeView } from './views/HomeView';
import { SemesterCreateView } from './views/Module/SemesterCreateView';
import { SemesterUpdateView } from './views/Module/SemesterUpdateView';
import { SemesterIndexView } from './views/Module/SemesterIndexView';
import { CohortIndexView } from './views/Cohort/CohortIndexView';
import { CohortCreateView } from './views/Cohort/CohortCreateView';
import { UserIndexView } from './views/User.ts/UserIndex';

export class App {
  private router: Router;

  constructor() {
    this.router = new Router();

    // Add routes to the router
    this.router.addRoute('/', new HomeView());

    //SemesterItem
    this.router.addRoute('/semester', new SemesterIndexView());
    this.router.addRoute('/semesterCreate', new SemesterCreateView());
    this.router.addRoute('/semesterUpdate', new SemesterUpdateView());

    //Cohort
    this.router.addRoute('/cohort', new CohortIndexView());
    this.router.addRoute('/cohortCreate', new CohortCreateView());

    //Users
    this.router.addRoute('/user', new UserIndexView());

    // Start the router
    this.router.start();
  }
}