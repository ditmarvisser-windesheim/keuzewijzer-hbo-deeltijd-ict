// import Api from './js/api/api';
// import * as Handlebars from 'handlebars/runtime';
// import './templates/layout.handlebars';
// const app: HTMLElement = document.getElementById('app') ?? document.createElement('div');
// const test = await Api.get('https://jsonplaceholder.typicode.com/todos/1');
// console.log(test);


// const template = Handlebars.compile(Handlebars.templates['layout']);
// const data = { title: 'My Title'};
// const html = template(data);

// console.log(html);

// function render() {
//     app.innerHTML = html;
// }

// //initial render
// render();
import { App } from "./app";

const app = new App();