import { Router } from './router';
import { HomeView } from './views/HomeView';
import { SemesterCreateView } from './views/Module/SemesterCreateView';
import { SemesterUpdateView } from './views/Module/SemesterUpdateView';
import { SemesterIndexView } from './views/Module/SemesterIndexView';

export class App {
  private router: Router;

  constructor() {
    this.router = new Router();

    // Add routes to the router
    this.router.addRoute('/', new HomeView());

    //SemesterItem
    this.router.addRoute('/semester', new SemesterIndexView());
    this.router.addRoute('/semesterCreate', new SemesterCreateView());
    this.router.addRoute('/semester/:id', new SemesterUpdateView());



    // Start the router
    this.router.start();
  }
}