import {
  defineNamespace,
  defineProjections,
  Model as ПитаниеMixin
} from '../mixins/regenerated/models/i-i-s-kur4-питание';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ПитаниеMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
