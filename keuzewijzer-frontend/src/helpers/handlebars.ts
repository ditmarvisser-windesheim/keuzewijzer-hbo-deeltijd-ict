import * as Handlebars from 'handlebars';

export function registerHelpers(this: any): void {
  Handlebars.registerHelper('eq', (a, b) => a == b)
  Handlebars.registerHelper('eq_not', (a, b) => a !== b)
  // Register more helpers here...
}
