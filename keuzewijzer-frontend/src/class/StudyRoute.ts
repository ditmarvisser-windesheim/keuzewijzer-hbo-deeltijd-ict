import { StudyRouteItem } from "./StudyRouteItem";

export class StudyRoute {
    name: string;
    approved_sb: boolean;
    approved_eb: boolean;
    note: string;
    send_sb: boolean;
    send_eb: boolean;
    userId: number;
    studyRouteItems: StudyRouteItem[];

    constructor(userId: number, studyRouteItems: StudyRouteItem[]) {
        this.name = "Studyroute from frontend"
        this.approved_sb = false;
        this.approved_eb = false;
        this.note = ""
        this.send_sb = false;
        this.send_eb = false;
        this.userId = userId
        this.studyRouteItems = studyRouteItems
    }
}