import { PrototipoSistemaFGVTemplatePage } from './app.po';

describe('PrototipoSistemaFGV App', function() {
  let page: PrototipoSistemaFGVTemplatePage;

  beforeEach(() => {
    page = new PrototipoSistemaFGVTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
