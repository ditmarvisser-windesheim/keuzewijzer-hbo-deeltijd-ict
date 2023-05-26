import { Semester } from "./Semester";

export class Cohort {
    id: number;
    name: string;
    year: number;
    semesterItems: Semester[] | null;
    userId: number | null;
    // user: User; TODO: fix this

    constructor() {
        this.id = 0;
        this.name = '';
        this.year = 0;
        this.semesterItems = null;
        this.userId = null;
        // this.user = new User();
    }

}
