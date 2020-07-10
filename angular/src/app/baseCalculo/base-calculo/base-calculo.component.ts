


import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
  BaseCalculoServiceProxy,
  BaseCalculoDto,
  BaseCalculoDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';


class PagedBaseCalculoRequestDto extends PagedRequestDto {
  keyword: string;
}

@Component({
  selector: 'app-base-calculo',
  templateUrl: './base-calculo.component.html',
  animations: [appModuleAnimation()]
})
export class BaseCalculoComponent extends PagedListingComponentBase<BaseCalculoDto> {
  baseCalculoList: BaseCalculoDto[] = [];
  keyword = '';

  constructor(
    injector: Injector,
    private _baseCalculoService: BaseCalculoServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedBaseCalculoRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._baseCalculoService
      .getAll(request.keyword, request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: BaseCalculoDtoPagedResultDto) => {
        this.baseCalculoList = result.items;
        this.showPaging(result, pageNumber);
      });
  }
}
