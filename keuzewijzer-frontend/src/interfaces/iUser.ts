import { ISemester } from "./iSemester";

export interface IUser {
    name: string;
    firstName: string;
    lastName: string;
    studyRoute: string | null;
    cohort: string | null;
    timedOut: boolean | null;
    semesterItems: ISemester[] | null;
    semesterItemsId: string | null;
    cohortId: string | null;
    id: string;
    userName: string;
    normalizedUserName: string;
    email: string;
    normalizedEmail: string;
    emailConfirmed: boolean;
    passwordHash: string;
    securityStamp: string | null;
    concurrencyStamp: string;
    phoneNumber: string | null;
    phoneNumberConfirmed: boolean;
    twoFactorEnabled: boolean;
    lockoutEnd: Date | null;
    lockoutEnabled: boolean;
    accessFailedCount: number;
}