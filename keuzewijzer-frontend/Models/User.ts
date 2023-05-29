import { Role } from "./Role"
import { StudyRoute } from "./StudyRoute";
import { Cohort } from "./Cohort"

export class User {
    id: string;
    name : string;
    firstName: string;
    lastName: string;
    roles: Role[];

    constructor() {
        this.id = '';
        this.name = '';
        this.firstName = ''
        this.lastName=''
        this.roles=[]
    }
}