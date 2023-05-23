import { View } from './View';

export class HomeView implements View {

    public template = `<div class="container">
    <div class="row">
        <div class="col-sm-12 col-md-8">
            <div class="row mb-3">
                <div class="col-md-2"></div>
                <div class="col-md-4 p-2 m-1 text-center">Semester 1</div>
                <div class="col-md-4 p-2 m-1 text-center">Semester 2</div>
            </div>

            {{#each years}}
            <div class="year-{{year}} droppable col-md-12">
                <div class="row">
                    <div class="col-md-2 align-self-center p-4 text-center">Jaar {{year}}</div>
                    <div class="col-md-4 landing-box align-self-center p-4 m-1 rounded-3 bg-primary text-center">
                        <span>
                            Aligned flex item
                        </span>
                    </div>
                    <div class="col-md-4 landing-box align-self-center p-4 m-1 rounded-3 bg-primary text-center">
                        <span>
                            Aligned flex item
                        </span>
                    </div>
                </div>
            </div>
            {{/each}}
        </div>

        <div class="col-md-4 d-none d-md-block">
            <input class="form-control mb-2" type="text" placeholder="Zoeken..." aria-label="default input example">

            <div class="accordion accordion-flush droppable" id="accordionFlushExample">
                <div class="accordion-item">
                    <h2 class="accordion-header" id="flush-headingOne">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                            data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
                            Exploring IT
                        </button>
                    </h2>
                    <div id="flush-collapseOne" class="accordion-collapse collapse" aria-labelledby="flush-headingOne"
                        data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">
                            <div class="row">
                                <div class="box align-self-center my-2 p-4 rounded-3 bg-danger text-center" data-id="test">test</div>
                                <div class="box align-self-center my-2 p-4 rounded-3 bg-danger text-center" data-id="test1">test 1</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
`;

    public data = {
        years: [
            { year: 1 },
            { year: 2 },
            { year: 3 },
            { year: 4 }
        ]
    };

    public setup(): void {
        console.log('HomeView.setup()');
        $(function () {
            $(".box").draggable({
                zIndex: 100,
                cursor: "move",
                helper: "clone",
                revert: "invalid",
                containment: "document",
                start: function (event, ui) {
                    var w = $(this).css('width');
                    var h = $(this).css('height');
                    ui.helper.css('width', w).css('height', h);
                }
            });

            $(".landing-box").droppable({
                accept: ".box",
                drop: function (event, ui) {
                    const droppedBox = $(ui.draggable);
                    const targetBox = $(this);

                    const boxClone = droppedBox.clone();

                    // Add an "x" button to the dropped box
                    const closeButton = $('<button class="remove-box">x</button>');
                    closeButton.click(function () {
                        // Remove the box from the landing box
                        $(this).parent().remove();

                        // Find the original box in the list and show it
                        const originalBox = $('.box[data-id="' + droppedBox.data('id') + '"]');
                        originalBox.show();
                    });

                    boxClone.append(closeButton);
                    // Append the dropped box to the target landing box
                    targetBox.append(boxClone);
                    // Hide the original box in the list
                    droppedBox.hide();
                }
            });

            $('#showResults').click(function () {
                // 'show the results of the drag and drop in an alert'
                // get the boxes in the active div
                var boxes = $('.active').find('.box');
                var result = '';

                // get the text of each box
                boxes.each(function (index, box) {
                    result += ' ' + $(box).find('span').text();
                });

                // show the result
                alert(result);
            });
        });
    }
}