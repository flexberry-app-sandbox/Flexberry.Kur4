import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  кодБлюда: DS.attr('number'),
  количество: DS.attr('number'),
  наименование: DS.attr('string'),
  цена: DS.attr('number'),
  питание: DS.belongsTo('i-i-s-kur4-питание', { inverse: 'регистрБлюд', async: false })
});

export let ValidationRules = {
  кодБлюда: {
    descriptionKey: 'models.i-i-s-kur4-регистр-блюд.validations.кодБлюда.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  количество: {
    descriptionKey: 'models.i-i-s-kur4-регистр-блюд.validations.количество.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  наименование: {
    descriptionKey: 'models.i-i-s-kur4-регистр-блюд.validations.наименование.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  цена: {
    descriptionKey: 'models.i-i-s-kur4-регистр-блюд.validations.цена.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  питание: {
    descriptionKey: 'models.i-i-s-kur4-регистр-блюд.validations.питание.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('РегистрБлюдE', 'i-i-s-kur4-регистр-блюд', {
    кодБлюда: attr('Код блюда', { index: 0 }),
    наименование: attr('Наименование', { index: 1 }),
    количество: attr('Количество', { index: 2 }),
    цена: attr('Цена', { index: 3 })
  });
};
