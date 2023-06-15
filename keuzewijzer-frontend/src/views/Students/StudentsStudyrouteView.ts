import Swal from 'sweetalert2';

import { type View } from '../View';
import { type ICohort } from 'interfaces/iCohort';
import { type IStudyRouteItem } from 'interfaces/iStudyRouteItem';
import { type ISemesterItem } from 'interfaces/iSemesterItems';
import { type IStudyRoute } from 'interfaces/iStudyRoute';
import AuthService from 'services/AuthService';
import { ApiService } from 'services/ApiService';
import { IUser } from 'interfaces/iUser';

export class StudentsStudyrouteView implements View {
    public params: Record<string, string> = {};
    private user= {} as IUser;
    public cohorts: ICohort[] = [];
    public semesterItems: ISemesterItem[] = [];
    public studyRouteItems: IStudyRouteItem[] = [];
    private studyRoute = {} as IStudyRoute;
    public modules: ISemesterItem[] = [];
    public authService!: AuthService;
    public apiService!: ApiService;

    private async getSemesterItem() {
        const semesterItems = await this.apiService.get<ISemesterItem[]>('/api/SemesterItem/cohort/2023'); 
        return semesterItems;
    }

    private async getStudyRouteItem() {
        const response = await this.apiService.get<IStudyRouteItem[]>(`/api/StudyRoute/user/${this.params.id}`); 
        //const response: any = await getUserStudyRoute('1');
        const studyRouteItemList: IStudyRouteItem[] = response;
        return studyRouteItemList;
    }

    private async getModules() {
        const modules = await this.apiService.get<ISemesterItem[]>('/api/SemesterItem/cohort/2023');
        return modules;
    }

    private async getStudyRoute() {
        const studyRoute = await this.apiService.get<IStudyRoute>(`/api/StudyRoute/${this.params.id}`);
        return studyRoute;
    }

    private async getUser() {
        const user = await this.apiService.get<IUser>(`/api/User/${this.params.id}`);
        return user;
    }

    public async fetchAsyncData() {
        console.log('HomeView.fetchAsyncData()');
        this.data.semesterItems = await this.getSemesterItem();
        this.data.studyRouteItems = await this.getStudyRouteItem();
        this.data.studyRoute = await this.getStudyRoute()
        this.data.user = await this.getUser();
        this.modules = await this.getModules();
        this.cohorts = await this.apiService.get<ICohort[]>('/api/Cohort');

        console.log(this.data);
    }

    public template = `<div class="container">
        <div>
            <h1 id='name'>Naam Achternaam</h1>
        </div>
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
            <form id="semester-form">
                <input type="hidden" id="id">
                <div class="form-group">
                    <label for="feedback">Feedback:</label>
                    <textarea class="form-control" id="feedback" rows="3"></textarea>
                    <div id="feedbackError" class="invalid-feedback"></div>
                </div>
                <button type="button" class="approve btn btn-success">Goedkeuren</button>
                <button type="button" class="reject btn btn-danger">Afkeuren en reminder sturen</button>
            </form>
        </div>
    </div>
    `;

    public data = {
        cohorts: this.cohorts,
        semesterItems: this.semesterItems,
        studyRouteItems: this.studyRouteItems,
        studyRoute: this.studyRoute,
        modules: this.modules,
        user: this.user,
        years: [
            { year: 1 },
            { year: 2 },
            { year: 3 },
            { year: 4 }
        ]
    };

    public setup(): void {
        
        const self = this;
        
        console.log(self.data.studyRoute);
        
        $(document).on("click", ".fa-info-circle", function () {
            var semesterItemId = $(this).closest(".box").data("id");
            var clickedSemesterItem = self.data.semesterItems.find(function (semesterItem) {
                return semesterItem.id === semesterItemId;
            });
            
            if (clickedSemesterItem != null) {
                const semesterItemName = clickedSemesterItem.name;
                const semesterItemDescription = clickedSemesterItem.description;

                $('#semesterItemInfoModal .modal-title').text(semesterItemName);
                $('#semesterItemInfoModal .modal-body').text(semesterItemDescription);
            }
        });
        
        $(async () => {
            let dropCount = 0;
            let yearCount = 4;
            $('#name').text(self.data.user.name);
            $('#feedback').text(self.data.studyRoute.note);

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

                    if (latestYear.find('.col-md-4').length >= 2) {
                        
                        const afstuderenBoxClone = afstuderenBox.clone();
                        afstuderenBox.replaceWith(newColumn);

                        const newRow = $('<div class="year-' + (yearCount + 1) + ' droppable col-md-12">' +
                            '<div class="row">' +
                            '<div class="col-md-2 align-self-center p-4 text-center">Jaar ' + (yearCount + 1) + '</div>' +
                            '</div>' +
                            '</div>');

                        latestYear.after(newRow);
                        afstuderenBoxClone.addClass('ui-droppable');
                        newRow.find('.row').append(afstuderenBoxClone);
                        yearCount++;
                    }

                    if (latestYear.find('.col-md-4').length === 1) {
                        afstuderenBox.before(newColumn);
                    }
                }

                const boxClone = droppedBox.clone();
                boxClone.removeClass('col-md-12 my-2').addClass('col-md-4 m-1');

                targetBox.hide().after(boxClone);

                if (droppedBox.data('id') !== 999) {
                    droppedBox.hide();
                }
            }

            function getStudyRouteItemsByAllYears() {
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

            $(".approve").click(async () => {
                const feedbackInput = $('#feedback').val() as string;
                   
                const studyRouteItemList = getStudyRouteItemsByAllYears()

                let studyRoute: IStudyRoute = {
                    userId: this.params.id,
                    studyRouteItems: studyRouteItemList,
                    approved_sb: true,
                    approved_eb: null,
                    note: feedbackInput,
                    send_sb: true,
                    send_eb: true
                };

                await this.saveStudyRoute(studyRoute);

            });
            
            $(".reject").click(async () => {
                const feedbackInput = $('#feedback').val() as string;

                const studyRouteItemList = getStudyRouteItemsByAllYears()

                let studyRoute: IStudyRoute = {
                    userId: this.params.id,
                    studyRouteItems: studyRouteItemList,
                    approved_sb: false,
                    approved_eb: null,
                    note: feedbackInput,
                    send_sb: true,
                    send_eb: null
                };

                await this.saveStudyRoute(studyRoute);

            });
        });
    }

    private async saveStudyRoute(studyRoute: IStudyRoute) {
        try {
            // Save StudyRoute via asynchronous API call
            const response = await this.apiService.post<IStudyRoute>('/api/StudyRoute', studyRoute);
            if (response.note === undefined) {
                Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
                return;
              }
            // Perform any further actions after successful save
            Swal.fire('Feedback is verstuurd naar  ' + this.user.name, '', 'success');

            // Go back to the semester overview wait for 3 seconds
            setTimeout(function () {
                window.location.href = '/students';
            }, 2000);

        } catch (error) {
            Swal.fire('Oeps!', 'Er is iets misgegaan.', 'error');
        }
    }
}
