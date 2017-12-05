<?php

/* form/fields.html.twig */
class __TwigTemplate_a7ef6529e1d3501741bb77ea3ce1e04452bf70a5a5b90b66da3a54de8a4a8832 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'date_time_picker_widget' => array($this, 'block_date_time_picker_widget'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_0778519ab78c93c1450c725a1e6737ac4322aaf2dd0ae782c7602b8ea211c8c4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0778519ab78c93c1450c725a1e6737ac4322aaf2dd0ae782c7602b8ea211c8c4->enter($__internal_0778519ab78c93c1450c725a1e6737ac4322aaf2dd0ae782c7602b8ea211c8c4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "form/fields.html.twig"));

        // line 9
        echo "
";
        // line 10
        $this->displayBlock('date_time_picker_widget', $context, $blocks);
        
        $__internal_0778519ab78c93c1450c725a1e6737ac4322aaf2dd0ae782c7602b8ea211c8c4->leave($__internal_0778519ab78c93c1450c725a1e6737ac4322aaf2dd0ae782c7602b8ea211c8c4_prof);

    }

    public function block_date_time_picker_widget($context, array $blocks = array())
    {
        $__internal_50fae104832fd17772ed4ca6f8a71a6499ded6bbed4ae81079abcc26433e2432 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_50fae104832fd17772ed4ca6f8a71a6499ded6bbed4ae81079abcc26433e2432->enter($__internal_50fae104832fd17772ed4ca6f8a71a6499ded6bbed4ae81079abcc26433e2432_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "date_time_picker_widget"));

        // line 11
        echo "    ";
        ob_start();
        // line 12
        echo "        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            ";
        // line 13
        $this->displayBlock("datetime_widget", $context, $blocks);
        echo "
            ";
        // line 15
        echo "                ";
        // line 16
        echo "            ";
        // line 17
        echo "        </div>
    ";
        echo trim(preg_replace('/>\s+</', '><', ob_get_clean()));
        
        $__internal_50fae104832fd17772ed4ca6f8a71a6499ded6bbed4ae81079abcc26433e2432->leave($__internal_50fae104832fd17772ed4ca6f8a71a6499ded6bbed4ae81079abcc26433e2432_prof);

    }

    public function getTemplateName()
    {
        return "form/fields.html.twig";
    }

    public function getDebugInfo()
    {
        return array (  52 => 17,  50 => 16,  48 => 15,  44 => 13,  41 => 12,  38 => 11,  26 => 10,  23 => 9,);
    }

    public function getSource()
    {
        return "{#
   Each field type is rendered by a template fragment, which is determined
   by the name of your form type class (DateTimePickerType -> date_time_picker)
   and the suffix \"_widget\". This can be controlled by overriding getBlockPrefix()
   in DateTimePickerType.

   See http://symfony.com/doc/current/cookbook/form/create_custom_field_type.html#creating-a-template-for-the-field
#}

{% block date_time_picker_widget %}
    {% spaceless %}
        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            {{ block('datetime_widget') }}
            {#<span class=\"input-group-addon\">#}
                {#<span class=\"fa fa-calendar\" aria-hidden=\"true\"></span>#}
            {#</span>#}
        </div>
    {% endspaceless %}
{% endblock %}
";
    }
}
