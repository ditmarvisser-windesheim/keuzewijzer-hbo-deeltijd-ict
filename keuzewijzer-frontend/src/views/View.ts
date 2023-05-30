export interface View {
  template: any;
  data: Record<string, any>;
  setup?(): void;
  fetchAsyncData?(): Promise<void>;
}
