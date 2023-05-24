export class Semester {
    public Id: number;
    public Name: string;
    public Description: string;
    public Year: number[];
    public Semester: number;
    public RequiredSemesterItem: Semester[];
    public DependentSemesterItem: Semester[];

    constructor() {
        this.Id = 0;
        this.Name = '';
        this.Description = '';
        this.Year = [];
        this.Semester = 0;
        this.RequiredSemesterItem = [];
        this.DependentSemesterItem = [];
    }


}
