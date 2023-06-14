import { type IStudyRouteItem } from './iStudyRouteItem';

export interface IStudyRoute {
  approved_sb: boolean
  approved_eb: boolean
  note: string
  send_sb: boolean
  send_eb: boolean
  userId: string
  studyRouteItems: IStudyRouteItem[]
};
