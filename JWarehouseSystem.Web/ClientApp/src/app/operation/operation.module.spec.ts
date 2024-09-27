import { OperationModule } from './operation.module';

describe('TransactionModule', () => {
  let operationModule: OperationModule;

  beforeEach(() => {
    operationModule = new OperationModule();
  });

  it('should create an instance', () => {
    expect(operationModule).toBeTruthy();
  });
});
