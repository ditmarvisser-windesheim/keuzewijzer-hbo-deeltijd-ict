import Api from '../api/api';
import { View } from './View';
import Swal from 'sweetalert2';
import cohort from '../api/cohort';


import { ICohort } from 'interfaces/iCohort';
import { IStudyRouteItem } from 'interfaces/iStudyRouteItem';
import { ISemesterItem } from 'interfaces/isSemesterItems';
import { IStudyRoute } from 'interfaces/iStudyRoute';

interface Module {
    id: number;
    cohorts: ICohort[] | null;
    dependentSemesterItem: any[] | null;
    description: string;
    modules: any[] | null;
    name: string;
    requiredSemesterItem: any[] | null;
    requiredSemesterItemId: number | null;
    semester: number;
    users: any[] | null;
    year: number[];
    yearJson: string;
};

export class HomeView implements View {
    public cohorts: ICohort[] = [];
    public semesterItems!: ISemesterItem[];
    public studyRouteItems:IStudyRouteItem[] = [];
    public modules: Module[] = [];

    public constructor() {
        console.log('HomeView.constructor()');
    }

    private async getSemesterItem() {
        const semesterItems = await Api.get('/api/SemesterItem/cohort/2023');
        console.log(semesterItems)
        return semesterItems;
    }

    private async getStudyRouteItem() {
        const response : any = await Api.get('/api/StudyRoute/user/1');
        const studyRouteItemList: IStudyRouteItem[] = response;
        return studyRouteItemList
    }
    private async getModules() {
        const modules = await Api.get('/api/SemesterItem/cohort/2021');
        return modules;
    }

    public async fetchAsyncData() {
        console.log('HomeView.fetchAsyncData()');
        this.data.semesterItems = await this.getSemesterItem();
        this.data.studyRouteItems = await this.getStudyRouteItem();
        this.modules = await this.getModules();
        this.cohorts = await cohort.getCohorts();
    }

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
                        {{#if (eq year 4)}}
                            <div data-id="afstuderen" class="col-md-4 align-self-center p-4 m-1 rounded-3 bg-secondary text-center">
                                Afstuderen
                            </div>
                        {{/if}}
                        {{#if (eq_not year 4)}}
                            <div class="col-md-4 landing-box align-self-center p-4 m-1 rounded-3 bg-primary text-center">
                                Aligned flex item
                            </div>
                        {{/if}}
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
                                    {{#each semesterItems}}
                                    <div class="box align-self-center my-2 p-4 rounded-3 bg-danger text-center" data-id="{{id}}">
                                        <i class="fa fa-info-circle" aria-hidden="true" data-toggle="modal" data-target="#semesterItemInfoModal"></i>
                                        {{name}}
                                    </div>
                                    {{/each}}
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="d-flex justify-content-end">
              <button type="button" class="create btn btn-primary">Studieroute opgeven</button>
            </div>
        </div>
    </div>
    `;

    public data = {
        cohorts: this.cohorts,
        semesterItems: this.semesterItems,
        studyRouteItems: this.studyRouteItems,
        modules: this.modules,
        years: [
            { year: 1 },
            { year: 2 },
            { year: 3 },
            { year: 4 }
        ],
    };

    public setup(): void {
        const self = this;


        $(document).on("click", ".fa-info-circle", function () {
            var semesterItemId = $(this).closest(".box").data("id");
            var clickedSemesterItem = self.data.semesterItems.find(function (semesterItem) {
                return semesterItem.id === semesterItemId;
            });

            if (clickedSemesterItem) {
                var semesterItemName = clickedSemesterItem.name;
                var semesterItemDescription = clickedSemesterItem.description;

                $("#semesterItemInfoModal .modal-title").text(semesterItemName);
                $("#semesterItemInfoModal .modal-body").text(semesterItemDescription);
            }
        });

        console.log('HomeView.setup()');
        console.log(this.data);
    
        $(async () => {
            let dropCount = 0;
            let yearCount = 4;
            let lastBox: JQuery<HTMLElement> | null = null;

            const { value: fruit } = await Swal.fire({
                icon: 'question',
                title: 'Welk cohort ben jij begonnen?',
                input: 'select',
                inputOptions: {
                  'Fruits': {
                    apples: 'Apples',
                    bananas: 'Bananas',
                    grapes: 'Grapes',
                    oranges: 'Oranges'
                  },
                  'Vegetables': {
                    potato: 'Potato',
                    broccoli: 'Broccoli',
                    carrot: 'Carrot'
                  },
                  'icecream': 'Ice cream'
                },
                inputPlaceholder: 'Select a fruit',
                showCancelButton: true,
                inputValidator: (value) => {
                  return new Promise((resolve) => {
                    if (value === 'oranges') {
                    //   resolve()
                    } else {
                      resolve('You need to select oranges :)')
                    }
                  })
                }
              })

            $(".box").draggable({
                zIndex: 100,
                cursor: "move",
                helper: "clone",
                revert: function (dropped: any) {
                    if (!dropped) {
                        // Revert the box to its original position
                        $(this).data("uiDraggable").originalPosition = {
                            top: 0,
                            left: 0
                        };
                        return true;
                    }
                },
                containment: "document",
                start: function (event, ui) {
                    const w = $(this).css('width');
                    const h = $(this).css('height');
                    ui.helper.css('width', w).css('height', h);
                }
            });
    
            setupDroppable($(".landing-box")); // Set up droppable behavior for existing landing boxes
    
            function setupDroppable(element: JQuery<HTMLElement>) {
                element.droppable({
                    accept: ".box",
                    drop: (event, ui) => {
                        const droppedBox: JQuery<HTMLElement> = $(ui.draggable);
                        const targetBox = $(event.target);
                        console.log(targetBox)
                        handleDropBox(droppedBox, targetBox)
                    }
                });
            }

            if (Array.isArray(self.data.studyRouteItems)) {
                self.data.studyRouteItems.forEach(function (studyRouteItem) {
                    // this will take the find the semesterItem
                    const boxId = studyRouteItem.semesterItemId
                    // .my-2 class is from the dropdown
                    const semesterItemBox = $('.box[data-id="' + boxId + '"].my-2');
                    let targetBox = null;

                    if (studyRouteItem.semester === 1) {
                        targetBox = $('.year-' + studyRouteItem.year + ' .col-md-4').eq(studyRouteItem.semester - 1);
                    } else {
                        targetBox = $('.year-' + studyRouteItem.year + ' .col-md-4').eq(studyRouteItem.semester);
                    }
                    handleDropBox(semesterItemBox, targetBox);
                });
            }

            function handleDropBox(droppedBox: JQuery<HTMLElement>, targetBox: JQuery<Element>) {
                if (droppedBox.data('id') === 999) {
                    dropCount++;
                    // Add a new column and move the "afstuderen" box to the new column
                    const latestYear = $('.year-' + yearCount);

                    const afstuderenBox = $('.year-' + yearCount + ' .row').find('.col-md-4[data-id="afstuderen"]');
                    const newColumn = $('<div class="col-md-4 landing-box align-self-center p-4 m-1 rounded-3 bg-primary text-center">' +
                        'Nieuw semester' +
                        '</div>');

                    setupDroppable(newColumn);
                    console.log(latestYear.find('.col-md-4').length)


                    if (latestYear.find('.col-md-4').length >= 2) {
                        
                        const afstuderenBoxClone = afstuderenBox.clone();
                        afstuderenBox.replaceWith(newColumn);

                        const newRow = $('<div class="year-' + (yearCount + 1) + ' droppable col-md-12">' +
                            '<div class="row">' +
                            '<div class="col-md-2 align-self-center p-4 text-center">Jaar ' + (yearCount + 1) + '</div>' +
                            '</div>' +
                            '</div>');

                        latestYear.after(newRow);
                        afstuderenBoxClone.addClass("ui-droppable");
                        newRow.find('.row').append(afstuderenBoxClone);
                        yearCount++;
                    }

                    if (latestYear.find('.col-md-4').length === 1) {
                        afstuderenBox.before(newColumn);
                    }
                }

                const boxClone = droppedBox.clone();
                boxClone.removeClass('col-md-12 my-2').addClass('col-md-4 m-1');

                const closeButton = $('<button class="remove-box">x</button>');
                closeButton.click(function () {
                    const boxToRemove = $(this).parent();

                    targetBox.show();
                    boxToRemove.remove();

                    const originalBox = $('.box[data-id="' + droppedBox.data('id') + '"]');

                    originalBox.show();
                    targetBox.show();
                    droppedBox.show();

                    // If repearatie semester is removed, remove the extra column
                    if (droppedBox.data('id') === 999) {
                        const latestYear = $('.year-' + yearCount);
                        var colElements = latestYear.find('.col-md-4:not(:hidden)');
                        var latestYearLenght = colElements.length;

                        console.log(latestYearLenght)

                        if (latestYearLenght === 1) {
                            const yearBefore = $('.year-' + (yearCount - 1));
                            const latestExtraColumn = yearBefore.find('.col-md-4').last();
                            const afstuderenBox = $('.year-' + yearCount + ' .row').find('.col-md-4[data-id="afstuderen"]');

                            latestExtraColumn.before(afstuderenBox);
                            latestExtraColumn.remove();
                            latestYear.remove();
                            yearCount--;
                        }

                        if (latestYearLenght === 2) {
                            const firstItem = latestYear.find('.col-md-4:not(:hidden):not([data-id="afstuderen"])').first()
                            const originalBox = $('.box[data-id="' + firstItem.attr('data-id') + '"]');
                            originalBox.show();
                            firstItem.remove();
                        }
                    }
                });
                boxClone.append(closeButton);
                targetBox.hide().after(boxClone);

                if (droppedBox.data('id') !== 999) {
                    droppedBox.hide();
                }
            }

            function getStudyRouteItemsBy() {
                let studyRouteItemList: IStudyRouteItem[] = [];
                // Searching for all years
                const years = $("div[class^='year-']");

               
                years.each(function (index) {
                    // finds the SemesterItems
                    const boxes = $(this).find('.box');
                    const afstuderenBoxes = $(this).find('.rounded-3[data-id!="afstuderen"]');

                    boxes.each(function (semesterIndex) {
                        // get the id of the SemesterItem
                        const semesterItemId = $(this).data('id');

                        // If there is only a afstudeer box it will not make a studyRouteItem for that year
                        if (semesterIndex < afstuderenBoxes.length) {
                            studyRouteItemList.push({ year: index + 1, semester: semesterIndex + 1, semesterItemId });
                        }
                    });
                });

                return studyRouteItemList
            }

            $(".create").click(async function () {
                const studyRouteItemList = getStudyRouteItemsBy()

                let studyRoute: IStudyRoute = {
                    userId: "1",
                    studyRouteItems: studyRouteItemList,
                    name: '',
                    approved_sb: false,
                    approved_eb: false,
                    note: '',
                    send_sb: false,
                    send_eb: false
                };

                try {
                    // Save StudyRoute via asynchronous API call
                    await Api.post('/api/StudyRoute', studyRoute);
                    // Perform any further actions after successful save
                } catch (error) {
                    // Handle the error, e.g., display an error message to the user
                }
            });
        });
    }
}
