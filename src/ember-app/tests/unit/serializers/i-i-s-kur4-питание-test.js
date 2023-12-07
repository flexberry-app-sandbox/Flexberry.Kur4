import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-kur4-питание', 'Unit | Serializer | i-i-s-kur4-питание', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-kur4-питание',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-kur4-виды',
    'transform:i-i-s-kur4-питания',

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
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
