export class Semester {
    public id: number;
    public name: string;
    public description: string;
    public year: number[];
    public semester: number;
    public requiredSemesterItem: Semester[];
    public dependentSemesterItem: Semester[];

    constructor() {
        this.id = 0;
        this.name = '';
        this.description = '';
        this.year = [];
        this.semester = 0;
        this.requiredSemesterItem = [];
        this.dependentSemesterItem = [];
    }


}
