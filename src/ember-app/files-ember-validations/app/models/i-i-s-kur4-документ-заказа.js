import {
  defineNamespace,
  defineProjections,
  Model as ДокументЗаказаMixin
} from '../mixins/regenerated/models/i-i-s-kur4-документ-заказа';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ДокументЗаказаMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
