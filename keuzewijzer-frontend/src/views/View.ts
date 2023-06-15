import type AuthService from '../services/AuthService';

export interface View {
  params?: Record<string, string>
  template: any
  data: Record<string, any>
  setup?: () => void
  fetchAsyncData?: () => Promise<void>
  authService?: AuthService
  requiresAuth?: boolean
}
