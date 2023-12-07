import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  видПитания: DS.attr('i-i-s-kur4-питания'),
  кодПитания: DS.attr('number'),
  регистрБлюд: DS.hasMany('i-i-s-kur4-регистр-блюд', { inverse: 'питание', async: false })
});

export let ValidationRules = {
  видПитания: {
    descriptionKey: 'models.i-i-s-kur4-питание.validations.видПитания.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  кодПитания: {
    descriptionKey: 'models.i-i-s-kur4-питание.validations.кодПитания.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  регистрБлюд: {
    descriptionKey: 'models.i-i-s-kur4-питание.validations.регистрБлюд.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ПитаниеE', 'i-i-s-kur4-питание', {
    кодПитания: attr('Код питания', { index: 0 }),
    видПитания: attr('Вид питания', { index: 1 }),
    регистрБлюд: hasMany('i-i-s-kur4-регистр-блюд', 'Блюда', {
      кодБлюда: attr('Код блюда', { index: 0 }),
      наименование: attr('Наименование', { index: 1 }),
      количество: attr('Количество', { index: 2 }),
      цена: attr('Цена', { index: 3 })
    })
  });

  modelClass.defineProjection('ПитаниеL', 'i-i-s-kur4-питание', {
    кодПитания: attr('Код питания', { index: 0 }),
    видПитания: attr('Вид питания', { index: 1 })
  });
};
