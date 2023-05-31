import { Cohort } from "./Cohort";
import { Semester } from "./Semester";

export class User {
    id: string;
    name: string;
    firstName: string;
    lastName: string;
    cohort: Cohort | null;
    timedOut: Date | null;
    cohortId: number | null;
    semesterItems: Semester[] | null;

    constructor(id: string, name: string, firstName: string, lastName: string) {
        this.id = id;
        this.name = name;
        this.firstName = firstName;
        this.lastName = lastName;
        this.cohort = null;
        this.timedOut = null;
        this.cohortId = null;
        this.semesterItems = null;
    }
}
