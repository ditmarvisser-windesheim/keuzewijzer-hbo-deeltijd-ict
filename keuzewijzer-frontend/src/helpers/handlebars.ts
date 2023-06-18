import * as Handlebars from 'handlebars';

// This file contains the Handlebars helpers that are used in the views
export function registerHelpers (this: any): void {
  Handlebars.registerHelper('eq', (a, b) => a === b);
  Handlebars.registerHelper('eq_not', (a, b) => a !== b);
  Handlebars.registerHelper('eq_not_null', (a) => a !== null);
  Handlebars.registerHelper('contains_role', (roles, values) => {
    let match = false;
    const valueList = values.split(',');

    valueList.forEach((value: string) => {
      if (roles?.includes(value)) {
        match = true;
      }
    });

    return match;
  });
}
