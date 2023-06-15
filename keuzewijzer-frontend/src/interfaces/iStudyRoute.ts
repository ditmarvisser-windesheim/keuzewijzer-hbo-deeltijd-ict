import { type IStudyRouteItem } from './iStudyRouteItem';

export interface IStudyRoute {
  approved_sb: boolean | null
  approved_eb: boolean | null
  note: string
  send_sb: boolean
  send_eb: boolean | null
  userId: string
  studyRouteItems: IStudyRouteItem[]
};
