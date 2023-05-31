export interface View {
  params?: Record<string, string>;
  template: any;
  data: Record<string, any>;
  setup?(): void;
  fetchAsyncData?(): Promise<void>;
}