export interface View {
  template: string;
  data: Record<string, any>;
  setup?(): void;
}
