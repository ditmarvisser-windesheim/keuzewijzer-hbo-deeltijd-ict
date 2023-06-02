export class StudyRouteItem {
    year: number;
    semester: number;
    semesterItemId: number;

    constructor(year: number, semester: number, semesterItemId: number) {
        this.year = year
        this.semester = semester
        this.semesterItemId = semesterItemId
    }
}