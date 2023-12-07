import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/ru/translations';

import IISKur4ДокументЗаказаLForm from './forms/i-i-s-kur4-документ-заказа-l';
import IISKur4ДолжностиLForm from './forms/i-i-s-kur4-должности-l';
import IISKur4КонтрагентыLForm from './forms/i-i-s-kur4-контрагенты-l';
import IISKur4ПитаниеLForm from './forms/i-i-s-kur4-питание-l';
import IISKur4СотрудникиLForm from './forms/i-i-s-kur4-сотрудники-l';
import IISKur4ДокументЗаказаEForm from './forms/i-i-s-kur4-документ-заказа-e';
import IISKur4ДолжностиEForm from './forms/i-i-s-kur4-должности-e';
import IISKur4КонтрагентыEForm from './forms/i-i-s-kur4-контрагенты-e';
import IISKur4ПитаниеEForm from './forms/i-i-s-kur4-питание-e';
import IISKur4СотрудникиEForm from './forms/i-i-s-kur4-сотрудники-e';
import IISKur4ДокументЗаказаModel from './models/i-i-s-kur4-документ-заказа';
import IISKur4ДолжностиModel from './models/i-i-s-kur4-должности';
import IISKur4КонтрагентыModel from './models/i-i-s-kur4-контрагенты';
import IISKur4ПитаниеModel from './models/i-i-s-kur4-питание';
import IISKur4РегистрБлюдModel from './models/i-i-s-kur4-регистр-блюд';
import IISKur4СотрудникиModel from './models/i-i-s-kur4-сотрудники';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-kur4-документ-заказа': IISKur4ДокументЗаказаModel,
    'i-i-s-kur4-должности': IISKur4ДолжностиModel,
    'i-i-s-kur4-контрагенты': IISKur4КонтрагентыModel,
    'i-i-s-kur4-питание': IISKur4ПитаниеModel,
    'i-i-s-kur4-регистр-блюд': IISKur4РегистрБлюдModel,
    'i-i-s-kur4-сотрудники': IISKur4СотрудникиModel
  },

  'application-name': 'Kur4',

  forms: {
    loading: {
      'spinner-caption': 'Данные загружаются, пожалуйста подождите...'
    },
    index: {
      greeting: 'Добро пожаловать на тестовый стенд ember-flexberry!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Меню'
          },
          'user-settings-service-checkbox': {
            caption: 'Использовать сервис сохранения пользовательских настроек'
          },
          'show-menu': {
            caption: 'Показать меню'
          },
          'hide-menu': {
            caption: 'Скрыть меню'
          },
          'language-dropdown': {
            caption: 'Язык приложения',
            placeholder: 'Выберите язык'
          }
        },
        login: {
          caption: 'Вход'
        },
        logout: {
          caption: 'Выход'
        }
      },

      footer: {
        'application-name': 'Kur4',
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Kur4',
          title: 'Kur4'
        },
        'application-version': {
          caption: 'Версия аддона {{version}}',
          title: 'Это версия аддона ember-flexberry, которая сейчас используется в этом тестовом приложении ' +
          '(версия npm-пакета + хэш коммита). ' +
          'Кликните, чтобы перейти на GitHub.'
        },
        index: {
          caption: 'Главная',
          title: ''
        },
        kur4: {
          caption: 'Kur4',
          title: 'Kur4',
          'i-i-s-kur4-контрагенты-l': {
            caption: 'Контрагенты',
            title: ''
          },
          'i-i-s-kur4-питание-l': {
            caption: 'Питание',
            title: ''
          },
          'i-i-s-kur4-должности-l': {
            caption: 'Должности',
            title: ''
          },
          'i-i-s-kur4-сотрудники-l': {
            caption: 'Сотрудники',
            title: ''
          },
          'i-i-s-kur4-документ-заказа-l': {
            caption: 'Документ заказа',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Сохранение завершилось успешно',
      'save-success-message': 'Объект сохранен',
      'save-error-message-caption': 'Ошибка сохранения',
      'delete-success-message-caption': 'Удаление завершилось успешно',
      'delete-success-message': 'Объект удален',
      'delete-error-message-caption': 'Ошибка удаления'
    },
    'i-i-s-kur4-документ-заказа-l': IISKur4ДокументЗаказаLForm,
    'i-i-s-kur4-должности-l': IISKur4ДолжностиLForm,
    'i-i-s-kur4-контрагенты-l': IISKur4КонтрагентыLForm,
    'i-i-s-kur4-питание-l': IISKur4ПитаниеLForm,
    'i-i-s-kur4-сотрудники-l': IISKur4СотрудникиLForm,
    'i-i-s-kur4-документ-заказа-e': IISKur4ДокументЗаказаEForm,
    'i-i-s-kur4-должности-e': IISKur4ДолжностиEForm,
    'i-i-s-kur4-контрагенты-e': IISKur4КонтрагентыEForm,
    'i-i-s-kur4-питание-e': IISKur4ПитаниеEForm,
    'i-i-s-kur4-сотрудники-e': IISKur4СотрудникиEForm
  },

});

export default translations;
