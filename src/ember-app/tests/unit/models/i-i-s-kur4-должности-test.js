import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-kur4-должности', 'Unit | Model | i-i-s-kur4-должности', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-kur4-документ-заказа',
    'model:i-i-s-kur4-должности',
    'model:i-i-s-kur4-контрагенты',
    'model:i-i-s-kur4-питание',
    'model:i-i-s-kur4-регистр-блюд',
    'model:i-i-s-kur4-сотрудники',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
