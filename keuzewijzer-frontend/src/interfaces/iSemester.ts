import { type ICohort } from './iCohort';

export interface ISemester {
  id?: number
  name: string
  description: string
  year: string[]
  semester: number
  requiredSemesterItemId: number[] | null
  requiredSemesterItem: ISemester[] | null
  dependentSemesterItem: ISemester[] | null
  cohorts: ICohort[] | null
  cohortsId: number[] | null

}
