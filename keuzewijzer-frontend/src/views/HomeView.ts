import { View } from './View';
import Api from '../js/api/api';
import { template } from 'handlebars';

export class HomeView implements View {
  public template = `
  <div class="container row">
  <div class="col-sm-12 col-md-8">
      <div class="d-flex flex-row justify-content-start bd-highlight mb-3 col-md-8">
          <div class="flex-grow-1"></div>
          <div class="flex-grow-1 p-2 bd-highlight align-self-center text-center">Flex item 2</div>
          <div class="flex-grow-1 p-2 bd-highlight align-self-center text-center">Flex item 3</div>
      </div>

      <div class="year-1 droppable">
          <div class="d-flex flex-column flex-sm-row justify-content-start bg-light">
              <div class="align-self-center p-4 text-center">Jaar 1</div>
              <div class="box flex-grow-1 align-self-center p-4 m-4 rounded-3 bg-danger text-center">Aligned flex item</div>
              <div class="box flex-grow-1 align-self-center p-4 m-4 rounded-3 bg-danger text-center">Aligned flex item</div>
          </div>
      </div>
      <div class="year-2 droppable">
          <div class="d-flex flex-column flex-sm-row justify-content-start bg-light">
              <div class="align-self-center p-4 text-center">Jaar 2</div>
              <div class="box flex-grow-1 align-self-center p-4 m-4 rounded-3 bg-danger text-center">Aligned flex item</div>
              <div class="box flex-grow-1 align-self-center p-4 m-4 rounded-3 bg-danger text-center">Aligned flex item</div>
          </div>
      </div>
      <div class="year-3 droppable">
          <div class="d-flex flex-column flex-sm-row justify-content-start bg-light">
              <div class="align-self-center p-4 text-center">Jaar 3</div>
              <div class="flex-grow-1 align-self-center p-4 m-4 rounded-3 bg-danger text-center">Aligned flex item</div>
              <div class="flex-grow-1 align-self-center p-4 m-4 rounded-3 bg-danger text-center">Aligned flex item</div>
          </div>
      </div>
      <div class="year-4 droppable">
          <div class="d-flex flex-column flex-sm-row justify-content-start bg-light">
              <div class="align-self-center p-4 text-center">Jaar 4</div>
              <div class="flex-grow-1 align-self-center p-4 m-4 rounded-3 bg-danger text-center">Aligned flex item</div>
              <div class="flex-grow-1 align-self-center p-4 m-4 rounded-3 bg-danger text-center">Aligned flex item</div>
          </div>
      </div>
  </div>

  <div class="col-md-4 d-none d-md-block">
      <input class="form-control mb-2" type="text" placeholder="Zoeken..." aria-label="default input example">

      <div class="accordion accordion-flush droppable" id="accordionFlushExample">
          <div class="accordion-item">
              <h2 class="accordion-header" id="flush-headingOne">
                  <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
                      Exploring IT
                  </button>
              </h2>
              <div id="flush-collapseOne" class="accordion-collapse collapse" aria-labelledby="flush-headingOne" data-bs-parent="#accordionFlushExample">
                  <div class="accordion-body">
                      <div class="d-flex flex-column">
                          <div class="box align-self-center my-2 p-4 rounded-3 bg-danger text-center">Aligned flex item</div>
                          <div class="box align-self-center my-2 p-4 rounded-3 bg-danger text-center">Aligned flex item</div>
                      </div>
                  </div>
              </div>
          </div>
          <div class="accordion-item">
              <h2 class="accordion-header" id="flush-headingOne">
                  <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
                      Exploring IT
                  </button>
              </h2>
              <div id="flush-collapseOne" class="accordion-collapse collapse" aria-labelledby="flush-headingOne" data-bs-parent="#accordionFlushExample">
                  <div class="accordion-body">
                      <div class="d-flex flex-column">
                          <div class="align-self-center my-2 p-4 rounded-3 bg-danger text-center">Aligned flex item</div>
                          <div class="align-self-center my-2 p-4 rounded-3 bg-danger text-center">Aligned flex item</div>
                      </div>
                  </div>
              </div>
          </div>
      </div>
  </div>
  `;

  public data = {};

  public setup(): void {
    console.log('HomeView.setup()');
    $(document).ready(function () {
      $(".box").draggable({
          revert: true,
          zIndex: 100,
          cursor: "move"
      });
      $(".box").droppable({
          accept: ".box",
          drop: function (event, ui) {
              var droppedBox = $(ui.draggable);
              var targetBox = $(this);
  
              // Get the text of the dropped box
              var droppedText = droppedBox.find("span").text();
  
              // Swap the text between the dropped box and the target box
              droppedBox.find("span").text(targetBox.find("span").text());
              targetBox.find("span").text(droppedText);
  
              // Reset the position of the dropped box
              droppedBox.css({ top: 0, left: 0 });
          }
      });
  
      $('#showResults').click(function () {
          // 'show the results of the drag and drop in a allert'
          //get the box in the div active
          var boxes = $('.active').find('.box');
          var result = '';
  
          //get the text of the box
          boxes.each(function (index, box) {
              result += ' ' + $(box).find('span').text();
          });
  
          //show the result
          alert(result);
      });
  
  });
  }
}
