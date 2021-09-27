import { logTemplatePage } from './app.po';

describe('log App', function() {
  let page: logTemplatePage;

  beforeEach(() => {
    page = new logTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
